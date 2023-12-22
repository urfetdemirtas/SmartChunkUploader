using Microsoft.AspNetCore.Mvc;

namespace UploadFileChunkWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public class FileChunkUploadModel
        {
            public required IFormFile FileChunk { get; set; }
            public required string FileName { get; set; }
            public int ChunkNumber { get; set; } 
        }

        [HttpPost]
        public async Task<IActionResult> UploadFileChunk(FileChunkUploadModel model)
        { 
            // Güvenlik ve doğrulama kontrolleri
            if (model.FileChunk == null || model.FileChunk.Length == 0)
                return BadRequest("Dosya parçası bulunamadı.");

            string[] validFileExtensions = { ".jpg", ".jpeg", ".png", ".tiff", ".zip", ".rar", ".mp4", ".avi" };
            string fileExtension = Path.GetExtension(model.FileName).ToLower();
            if (!validFileExtensions.Contains(fileExtension))
                return BadRequest("Geçersiz dosya türü.");

            if (model.ChunkNumber <= 0)
                return BadRequest("Geçersiz parça numarası.");

            // Dosya yükleme klasörü
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");

            // Eşzamanlı yüklemeleri yönetmek için benzersiz bir dosya adı oluşturun
            var uniqueFileName = model.FileName;
            var filePath = Path.Combine(uploadPath, uniqueFileName);

            try
            {
                // Dosya klasörünü oluştur
                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                // Dosya parçasını yaz
                using (var stream = new FileStream(filePath, model.ChunkNumber == 1 ? FileMode.Create : FileMode.Append))
                    await model.FileChunk.CopyToAsync(stream);
            }
            catch (Exception ex)
            {
                // Hata günlüğe kaydediliyor
                _logger.LogError($"Dosya yükleme hatası: {ex.Message}");
                return StatusCode(500, "Dosya yükleme sırasında bir hata oluştu.");
            }

            return Ok("Parça başarıyla yüklendi.");
        }
    }
}