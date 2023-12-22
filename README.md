# SmartChunkUploader
Bu proje, dosyaların parçalara bölünerek (chunks) sunucuya etkin ve güvenli bir şekilde yüklenmesini sağlayan bir ASP.NET Core API'si sunmaktadır. Her parça, dosyanın bütünlüğünü koruyarak ve yükleme sürecinde oluşabilecek hataları minimuma indirgeyerek ayrı ayrı işlenir. Güvenlik kontrolleri, geçerli dosya uzantılarının doğrulamasını içerir ve eşzamanlı yüklemeleri yönetmek için benzersiz dosya adları kullanılır. Bu sistem, büyük dosyaların yüklenmesi, internet bağlantısının kesilmesi durumunda yüklemenin devam etmesi ve sunucu kaynaklarının verimli kullanımı gibi durumlar için idealdir.

Projede, ASP.NET Core'un robust yapısı kullanılarak, dosya yükleme işleminin güvenliği ve etkinliği artırılmıştır. Hata yönetimi ve günlüğe kaydetme özellikleri, hata ayıklama ve sistem izleme süreçlerini kolaylaştırır.

![Uploading image.png…]()
