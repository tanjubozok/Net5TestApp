using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;
using System;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(200);
            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");

            builder.HasData(new Advertisement[]
            {
                new()
                {
                    Id=1,
                    Title="Yazılım Uzmanı",
                    Status=true,
                    Description="C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış",
                    CreatedDate=DateTime.Now
                },
                new()
                {
                    Id=2,
                    Title=".Net Core / Angular Yazılım Geliştirme Uzmanı",
                    Status=true,
                    Description="Üniversitelerin Mühendislik bölümlerinden mezun,\r\nEn az 2 yıl profesyonel iş tecrübesi olan,\r\nAskerlik hizmetini tamamlamış,\r\nAngular ve Typescript teknolojilerini kullanarak proje geliştirmiş,\r\nWeb API, LINQ, Entity Framework ve MSSQL bilgisi olan,\r\nC#, .NET Core bilgisi ve. NET Teknolojilerine hakim,\r\nVersiyon kontrol sistemleri (TFS, GIT) konusunda bilgi sahibi,\r\nTakım çalışmasına yatkın ve birlikte çalışmanın yarattığı sinerjinin farkında olan,\r\nİş takibi kuvvetli,\r\nTeknoloji ve yenilikleri takip edebilen,\r\nÖğrenmeye ve gelişmeye açık",
                    CreatedDate=DateTime.Now
                },
                new()
                {
                    Id=3,
                    Title="Back End Developer",
                    Status=true,
                    Description="Proje deneyimi olan,\r\nVeritabanı mimarilerine hakim,\r\nServis yapıları konusunda tecrübeleri,\r\nPHP dili ve codeigniter üzerinde master seviyede ve MVC yapıları hakkında bilgi sahibi,\r\nEn az 5 yıl tecrübeli,\r\nLinux sunucular üzerinde PHP geliştirmiş,\r\nTakım çalışmasına ve ekip ruhuna uyum sağlayabilen,\r\nEn az 3 sene tecilli veya askerliğini bitirmiş,\r\nJetBrains araçlarını kullanabilen,\r\nVersiyon yönetimi konusunda tecrübeli",
                    CreatedDate=DateTime.Now
                },
                new()
                {
                    Id=4,
                    Title=".Net Yazılım Uzmanı",
                    Status=true,
                    Description="Tercihen üniversitelerin Bilgisayar Mühendisliği, Yazılım Mühendisliği, Bilgisayar Programcılığı ya da benzer bölümlerden mezun,\r\nMinimum 3 yıl .NET teknolojileriyle (C#, ASP) yazılım geliştirmesi tecrübesi olan,\r\nMicrosoft SQL Server tecrübesi olan, (View, Stored Procedure, SQL/TSQL)\r\nTercihen Web Service , Web Api geliştirmiş olan,\r\nTercihen HTML, CSS, Javascript bilgisine sahip\r\nKurumsal uygulamaların tasarım, implemantasyon, test, performans izleme, dokümantasyon tecrübesine sahip,\r\nTeknik dokümanları anlayabilecek seviyede İngilizce bilen,\r\nAnalitik düşünce ve problem çözme becerisi kuvvetli, iletişim yönü güçlü, değişime, yeni teknolojilere ve gelişmeye açık,\r\nErkek adaylar için askerliğini tamamlamış,",
                    CreatedDate=DateTime.Now
                },
                new()
                {
                    Id=5,
                    Title="Yazılım Uzmanı",
                    Status=true,
                    Description="C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış",
                    CreatedDate=DateTime.Now
                },
                new()
                {
                    Id=6,
                    Title="Yazılım Uzmanı",
                    Status=true,
                    Description="NET ve MSSQL konularında uzman,\r\nFront End ve Back End deneyimi bulunan,\r\nSEO optimizasyonları konusunda bilgi sahibi,\r\nNET platformunda Object Oriented programlama tecrübesine sahip,\r\nVB.NET dilinde kodlama yapmış, VB.NET diline hakim, C#.NET ile ilgili bilgi sahibi,\r\nHTML 5, CSS, Javascript, Ajax, CRM, Php, Headless, Hubspot konularında bilgi sahibi,\r\nİçerik yönetim sistemleri hakkında bilgi sahibi,\r\nSQL Server konusunda deneyimi olan,\r\nWeb uygulamaları geliştirmiş adayların başvurularını bekliyoruz.",
                    CreatedDate=DateTime.Now
                }
            });
        }
    }
}
