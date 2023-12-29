# SmartChunkUploader

Bu proje, dosyaların parçalara bölünerek (chunks) sunucuya etkin ve güvenli bir şekilde yüklenmesini sağlayan bir ASP.NET Core API'sidir. Her parça, dosyanın bütünlüğünü koruyarak ve yükleme sürecinde oluşabilecek hataları minimuma indirgeyerek ayrı ayrı işlenir.

## Özellikler

- **Güvenlik Kontrolleri:** Geçerli dosya uzantılarının doğrulamasını içerir ve eşzamanlı yüklemeleri yönetmek için benzersiz dosya adları kullanılır.
- **Dosya Hash Kontrolü:** Yüklenen her dosya parçasının hash değeri hesaplanır ve tüm parçalar yüklendikten sonra, sunucu tarafında dosyanın tamamının hash değeri tekrar hesaplanarak doğruluğu kontrol edilir.
- **Hatalı Yüklemelerde Dosya Silme:** Eğer dosya hash değerleri uyuşmazsa, hatalı dosya sunucudan otomatik olarak silinir.
- **Kapsamlı Günlüğe Kaydetme:** Sistem, dosya yükleme işlemleri sırasında oluşan hataları ve önemli olayları detaylı bir şekilde günlüğe kaydeder.
- **Etkin Kaynak Kullanımı:** Dosyaların parçalara bölünerek yüklenmesi, sunucu kaynaklarının daha etkin kullanılmasını sağlar.

## Kullanım

Bu bölümde, projenin nasıl kullanılacağına dair talimatlar yer almalıdır.

## Katkıda Bulunma

Projeye katkıda bulunmak isteyenler için yönergeler.

## Lisans

Bu proje [LİSANS](LICENSE) altında lisanslanmıştır.

![image](https://github.com/urfetdemirtas/SmartChunkUploader/assets/11385403/df23fae5-fa1f-4187-b10a-d316ea105609)

![image](https://github.com/urfetdemirtas/SmartChunkUploader/assets/11385403/a7957240-5cb0-4066-83df-26527db82e5e)

# Ürfet Demirtaş
2024 yılına girmeden... (22.12.2023)

www.urfetdemirtas.com
