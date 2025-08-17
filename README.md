# 🌍 Tatil & Seyahat Projesi (ASP.NET MVC)

![ASP.NET MVC](https://img.shields.io/badge/Framework-ASP.NET%20MVC-blue?style=for-the-badge)  
![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-orange?style=for-the-badge)  
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red?style=for-the-badge)  
![Bootstrap](https://img.shields.io/badge/UI-Bootstrap-purple?style=for-the-badge)  

Bu proje, **Murat Yücedağ’ın 50 Derste Asp.Net Mvc ile Tatil & Seyahat Sitesi** kursu kapsamında geliştirilmiştir.  
Amaç, **bir tatil & seyahat blogu** oluşturarak ASP.NET MVC temellerini öğrenmek ve uygulamaktır.  

---

## 🚀 Özellikler
- 📝 Blog gönderileri ekleme, listeleme, güncelleme, silme  
- 📖 Blog detay sayfası  
- ℹ️ Hakkımızda ve İletişim sayfaları  
- 🔑 Admin Paneli üzerinden CRUD işlemleri  
- ⚡ Dinamik sayfa yapısı  
- 📱 Modern ve responsive arayüz  

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|-----------|----------|
| ![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-blue) | Web uygulaması geliştirme |
| ![Entity Framework](https://img.shields.io/badge/Entity-Framework-orange) | ORM yapısı (Code First) |
| ![SQL Server](https://img.shields.io/badge/SQL-Server-red) | Veritabanı (SQL Server Management Studio - SSMS) |
| ![Bootstrap](https://img.shields.io/badge/Bootstrap-CSS-purple) | Responsive UI tasarımı |
| ![LINQ](https://img.shields.io/badge/LINQ-C%23-green) | Veritabanı sorguları |

---

## 📸 Proje Görselleri

🏠 **Ana Sayfa**  


![tatil-seyahat](https://github.com/user-attachments/assets/66ca0c04-4d6a-4257-9250-f4e7cda8eb2b)


🚖 **Hakkımızda Sayfası**  

<img width="1917" height="958" alt="hakkimizda" src="https://github.com/user-attachments/assets/b40b28ab-08cb-4f93-9b90-e3baf840aaa7" />


---

🚖 **İletisim Sayfası**

<img width="1908" height="960" alt="iletisim" src="https://github.com/user-attachments/assets/65a844a4-1f8a-492b-ad0e-b750aba4abfa" />


---

🔑 **Admin Paneli**  


<img width="1914" height="965" alt="admin" src="https://github.com/user-attachments/assets/8517c7bb-7427-4b1e-8ed8-5bdb7db7a451" />


---

## ⚙️ Kurulum & Çalıştırma

Projeyi bilgisayarınıza klonladıktan sonra **Visual Studio** ile açın.  
`Web.config` dosyasında veritabanı bağlantınızı ayarlayın.  

**Windows Authentication için:**
```xml
<connectionStrings>
    <add name="Context" 
         connectionString="Data Source=;Initial Catalog=TatilSeyahatDB;Integrated Security=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
