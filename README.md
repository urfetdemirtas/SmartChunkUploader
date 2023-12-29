# SmartChunkUploader
Bu proje, dosyaların parçalara bölünerek (chunks) sunucuya etkin ve güvenli bir şekilde yüklenmesini sağlayan bir ASP.NET Core API'sidir. Her parça, dosyanın bütünlüğünü koruyarak ve yükleme sürecinde oluşabilecek hataları minimuma indirgeyerek ayrı ayrı işlenir. Güvenlik kontrolleri, geçerli dosya uzantılarının doğrulamasını içerir ve eşzamanlı yüklemeleri yönetmek için benzersiz dosya adları kullanılır. Bu sistem, büyük dosyaların yüklenmesi, internet bağlantısının kesilmesi durumunda yüklemenin devam etmesi ve sunucu kaynaklarının verimli kullanımı gibi durumlar için idealdir.

Projede, ASP.NET Core'un robust yapısı kullanılarak, dosya yükleme işleminin güvenliği ve etkinliği artırılmıştır. Hata yönetimi ve günlüğe kaydetme özellikleri, hata ayıklama ve sistem izleme süreçlerini kolaylaştırır. Ek olarak, bu projede aşağıdaki önemli özellikler de yer almaktadır:

*Dosya Hash Kontrolü:* Yüklenen her dosya parçasının (chunk) hash değeri hesaplanır ve tüm parçalar yüklendikten sonra, sunucu tarafında dosyanın tamamının hash değeri tekrar hesaplanarak doğruluğu kontrol edilir. Bu, dosyanın bütünlüğünü ve veri bozulmalarına karşı korunmasını sağlar.

*Hatalı Yüklemelerde Dosya Silme:* Eğer dosya hash değerleri uyuşmazsa, yani dosya doğru bir şekilde yüklenmemişse, hatalı dosya sunucudan otomatik olarak silinir. Bu, veri tutarlılığını korumak ve yanlış yüklemelerin sisteme zarar vermesini önlemek için önemli bir güvenlik önlemidir.

*Kapsamlı Günlüğe Kaydetme:* Sistem, dosya yükleme işlemleri sırasında oluşan hataları ve önemli olayları detaylı bir şekilde günlüğe kaydeder. Bu, sistem yöneticilerinin hata ayıklama ve izleme işlemlerini daha verimli bir şekilde yapmalarına olanak tanır.

*Etkin Kaynak Kullanımı:* Dosyaların parçalara bölünerek yüklenmesi, sunucu kaynaklarının daha etkin kullanılmasını sağlar. Özellikle büyük dosyaların yüklenmesi sırasında, sistem kaynaklarının aşırı yüklenmesini önler ve daha dengeli bir yükleme süreci sunar.

Bu özellikler, projenin güvenlik, verimlilik ve kullanıcı deneyimi açısından üstün bir çözüm sunmasını sağlamaktadır. Özellikle büyük dosya yüklemeleri ve kesintili ağ bağlantıları gibi zorlu senaryolarda, bu sistem güvenilir ve etkin bir performans sergilemektedir.

![image](https://github.com/urfetdemirtas/SmartChunkUploader/assets/11385403/df23fae5-fa1f-4187-b10a-d316ea105609)

![image](https://github.com/urfetdemirtas/SmartChunkUploader/assets/11385403/8c29c90a-71b5-4d2b-a8cf-44cb79a5086c)

![image](https://github.com/urfetdemirtas/SmartChunkUploader/assets/11385403/a7957240-5cb0-4066-83df-26527db82e5e)

# Ürfet Demirtaş
2024 yılına girmeden... (22.12.2023)

www.urfetdemirtas.com
