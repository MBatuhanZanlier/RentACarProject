# Renta Car Projesi Hakkında 
Bu proje, araç kiralama üzerine odaklanan bir projedir. Projede belirli lokasyonlara göre araçları listeleyebilir ve seçebilirsiniz. Örneğin, alış yerini ve teslim yerini seçerek belirli tarih aralıkları için araçları listeleyebilirsiniz. Ayrıca, tüm araçları genel araçlar bölümünden gözden geçirebilirsiniz. 
# Projede Kullanılan Teknolojiler  
- CQRS Desing Pattern
- Mediator desing Pattern
- .Net Core 6.0
- EntityFramework
- MsSql
- MediaTR
## CQRS Desing Pattern Hakkında Bilgi (Command Query Responsibility Segregation)

CQRS'nin temel özellikleri şunlardır:

- Komut ve Sorgu Ayrımı: CQRS, CRUD (Create, Read, Update, Delete) operasyonlarını (veri oluşturma, okuma, güncelleme, silme) ayrı modeller ve servisler kullanarak yönetmeyi önerir. Bu sayede yazma (komut) işlemleri için farklı bir model ve servisler kullanılırken, okuma (sorgu) işlemleri için farklı bir model ve servisler kullanılır.

- Farklı Modeller: CQRS, uygulamanın içinde kullanılan veri modellerinin komut ve sorgu işlemleri için farklı olmasını destekler. Yazma işlemleri genellikle daha karmaşık ve işleme odaklı olabilirken, okuma işlemleri genellikle sorgu performansını optimize etmek amacıyla düzenlenmiş olabilir.

- Performans ve Ölçeklenebilirlik: CQRS, uygulamanın performansını artırabilir çünkü yazma ve okuma işlemleri farklı optimizasyon stratejileri ile ele alınabilir. Özellikle okuma işlemlerinde performansı artırmak için özel olarak tasarlanmış veri depolama ve sorgulama yöntemleri kullanılabilir.

- Modülerlik ve Bakım Kolaylığı: CQRS, uygulamanın modüler hale gelmesini sağlar çünkü yazma ve okuma işlemleri farklı servisler tarafından yönetilir. Bu da kodun bakımını kolaylaştırabilir ve yeni gereksinimlerin uygulamaya entegrasyonunu daha esnek hale getirebilir.

- Karmaşıklığı Azaltma: Büyük ve karmaşık sistemlerde CQRS, karmaşıklığı azaltabilir çünkü yazma ve okuma işlemleri farklı sorumluluklara sahip olur ve bu sayede sistem daha modüler ve anlaşılır hale gelir.

## Proje Hakkında Görseller 
## Alış yeri ,Teslim yeri ve Tarih  
![Ekran Görüntüsü (123)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/e6585653-8a99-4fe8-b3f4-663062245884)
![Ekran Görüntüsü (124)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/c713f3f3-245b-44ee-ba12-30eef4adc25f)
## Alış yeri ,Teslim yeri ve Tarih  lokasyonlarına göre arama sonucunda listelenen Araçlar 
![Ekran Görüntüsü (125)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/c5cd0423-ffab-4750-9a89-2ef69f8e98a8)
## Tüm Araçlar listesi ve Modal dan ayrıntıları görüntüleme  
![Ekran Görüntüsü (130)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/2b849aa6-8f1b-4039-9db0-9fcb4eedf88b)
![Ekran Görüntüsü (129)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/c2fe233e-7ad2-400e-9acb-a3cdc52813f6) 
## Admin Sayfası Bütün Araçlar Listesi 
![Ekran Görüntüsü (131)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/7d5e9c51-03af-44d6-967d-4ee13fbb725b) 
## Araç Güncelleme Sayfası 
![Ekran Görüntüsü (133)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/599ee9fe-c463-4ab5-bf85-dfcc820369d6) 
## Yeni Araç Oluşturma sayfası 
![Ekran Görüntüsü (134)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/417eae87-a942-4b66-9a89-cb2f25e45779) 
## MsSql Tablolar 
![Ekran Görüntüsü (137)](https://github.com/MBatuhanZanlier/RentACarProject/assets/158502460/07416549-c369-4697-bbf2-82545f6e470d)
