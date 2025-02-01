ASP.NET Core MVC İletişim Formu  

Bu proje, ASP.NET Core Web App (MVC) ve MSSQL kullanılarak geliştirilmiş bir iletişim formu uygulamasıdır. Kullanıcılar, aşağıdaki alanları doldurarak verilerini gönderebilir:  

- Telefon 
- E-Posta  
- Departman (Muhasebe, Teknik Destek, İnsan Kaynakları)  
- Mesaj

Gönderilen veriler MSSQL veritabanına kaydedilir.  

Projeyi Çalıştırma  

1. Gerekli Bağımlılıklar  
Bu projeyi çalıştırmadan önce aşağıdaki bileşenlerin sisteminizde yüklü olduğundan emin olun:  

- [.NET 7+ SDK](https://dotnet.microsoft.com/download)  
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (ASP.NET ve MSSQL desteğiyle)  
- MSSQL Server & SQL Server Management Studio (SSMS)  

2. Projeyi Çekme  

git clone <repository-url>
cd proje-dizini


3. Veritabanı Bağlantısını Yapılandırma  
appsettings.json dosyasında ConnectionStrings bölümünü kendi MSSQL bağlantı bilgilerinize göre güncelleyin:  

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;MultipleActiveResultSets=true"
}


4. Veritabanı Oluşturma ve Migration İşlemleri  

Aşağıdaki komutları kullanarak veritabanını oluşturun ve gerekli tabloları ekleyin:  

dotnet ef migrations add InitialCreate
dotnet ef database update


5. Uygulamayı Çalıştırma  

dotnet run

Ardından tarayıcınızda http://localhost:5000 veya http://localhost:5001 adresine giderek uygulamayı test edebilirsiniz.  

Proje Yapısı  


📂 ProjeKlasörü
│-- 📂 Controllers          # MVC Controller'lar
│-- 📂 Models              # Veritabanı modelleri
│-- 📂 Views               # Razor View dosyaları
│-- 📂 Data                # DbContext ve migration dosyaları
│-- appsettings.json       # Uygulama yapılandırması
│-- Program.cs             # Giriş noktası
│-- Startup.cs             # Servisler ve Middleware konfigürasyonu


Bu README dosyasını projenizin özelliklerine göre özelleştirebilirsiniz. 
