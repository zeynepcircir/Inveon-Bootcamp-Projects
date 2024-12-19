# Kütüphane Yönetim Sistemi Web Uygulaması

Bu proje, temel kitap yönetimi işlemlerini gerçekleştirebileceğiniz bir Kütüphane Yönetim Sistemi web uygulamasıdır. Kitaplarla ilgili CRUD (Create, Read, Update, Delete) işlemleri desteklenmektedir. Uygulama, .NET platformunda geliştirilmiş olup Entity Framework Core ve SQLite ile entegre edilmiştir.

## Uygulamanın Özellikleri
- **Kitap Listeleme**: Tüm mevcut kitapların bir tablo formatında görüntülenmesi.
- **Kitap Detayları**: Belirli bir kitabın tüm bilgilerine detaylı olarak erişim.
- **Kitap Ekleme**: Yeni kitap eklemek için bir form aracılığıyla veri girişi.
- **Kitap Güncelleme**: Kayıtlı kitapların bilgilerinin düzenlenmesi.
- **Kitap Silme**: Kütüphane sistemindeki kitapların kaldırılması.

## Kullanılan Teknolojiler ve Mimari
- **Backend**: ASP.NET Core
- **Frontend**: Razor Pages (cshtml)
- **Veritabanı**: SQLite
- **ORM**: Entity Framework Core
- **Mimari Desenler**: Repository Pattern ve UnitOfWork Pattern

## Proje Yapısı
- **Models**: Kitap bilgilerini ve diğer veri yapılarını temsil eden modeller.
- **Repositories**: Veritabanı işlemleri için soyutlama sağlayan repository katmanı.
- **UnitOfWork**: Veritabanı işlemlerini tek bir context üzerinden yönetme.
- **Controllers**: HTTP isteklerini yöneten kontrolörler.
- **Views**: Kullanıcı arayüzü için Razor tabanlı sayfalar.
