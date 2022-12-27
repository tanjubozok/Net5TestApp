﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Net5TestApp.DataAccess.Concrete.EfCore.Context;

namespace Net5TestApp.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221227233046_ProvidedServiceSeedData")]
    partial class ProvidedServiceSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(4727),
                            Description = "C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış",
                            Status = true,
                            Title = "Yazılım Uzmanı"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5097),
                            Description = "Üniversitelerin Mühendislik bölümlerinden mezun,\r\nEn az 2 yıl profesyonel iş tecrübesi olan,\r\nAskerlik hizmetini tamamlamış,\r\nAngular ve Typescript teknolojilerini kullanarak proje geliştirmiş,\r\nWeb API, LINQ, Entity Framework ve MSSQL bilgisi olan,\r\nC#, .NET Core bilgisi ve. NET Teknolojilerine hakim,\r\nVersiyon kontrol sistemleri (TFS, GIT) konusunda bilgi sahibi,\r\nTakım çalışmasına yatkın ve birlikte çalışmanın yarattığı sinerjinin farkında olan,\r\nİş takibi kuvvetli,\r\nTeknoloji ve yenilikleri takip edebilen,\r\nÖğrenmeye ve gelişmeye açık",
                            Status = true,
                            Title = ".Net Core / Angular Yazılım Geliştirme Uzmanı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5100),
                            Description = "Proje deneyimi olan,\r\nVeritabanı mimarilerine hakim,\r\nServis yapıları konusunda tecrübeleri,\r\nPHP dili ve codeigniter üzerinde master seviyede ve MVC yapıları hakkında bilgi sahibi,\r\nEn az 5 yıl tecrübeli,\r\nLinux sunucular üzerinde PHP geliştirmiş,\r\nTakım çalışmasına ve ekip ruhuna uyum sağlayabilen,\r\nEn az 3 sene tecilli veya askerliğini bitirmiş,\r\nJetBrains araçlarını kullanabilen,\r\nVersiyon yönetimi konusunda tecrübeli",
                            Status = true,
                            Title = "Back End Developer"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5103),
                            Description = "Tercihen üniversitelerin Bilgisayar Mühendisliği, Yazılım Mühendisliği, Bilgisayar Programcılığı ya da benzer bölümlerden mezun,\r\nMinimum 3 yıl .NET teknolojileriyle (C#, ASP) yazılım geliştirmesi tecrübesi olan,\r\nMicrosoft SQL Server tecrübesi olan, (View, Stored Procedure, SQL/TSQL)\r\nTercihen Web Service , Web Api geliştirmiş olan,\r\nTercihen HTML, CSS, Javascript bilgisine sahip\r\nKurumsal uygulamaların tasarım, implemantasyon, test, performans izleme, dokümantasyon tecrübesine sahip,\r\nTeknik dokümanları anlayabilecek seviyede İngilizce bilen,\r\nAnalitik düşünce ve problem çözme becerisi kuvvetli, iletişim yönü güçlü, değişime, yeni teknolojilere ve gelişmeye açık,\r\nErkek adaylar için askerliğini tamamlamış,",
                            Status = true,
                            Title = ".Net Yazılım Uzmanı"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5105),
                            Description = "C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış",
                            Status = true,
                            Title = "Yazılım Uzmanı"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5108),
                            Description = "NET ve MSSQL konularında uzman,\r\nFront End ve Back End deneyimi bulunan,\r\nSEO optimizasyonları konusunda bilgi sahibi,\r\nNET platformunda Object Oriented programlama tecrübesine sahip,\r\nVB.NET dilinde kodlama yapmış, VB.NET diline hakim, C#.NET ile ilgili bilgi sahibi,\r\nHTML 5, CSS, Javascript, Ajax, CRM, Php, Headless, Hubspot konularında bilgi sahibi,\r\nİçerik yönetim sistemleri hakkında bilgi sahibi,\r\nSQL Server konusunda deneyimi olan,\r\nWeb uygulamaları geliştirmiş adayların başvurularını bekliyoruz.",
                            Status = true,
                            Title = "Yazılım Uzmanı"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AdvertisementAppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementAppUserStatusId")
                        .HasColumnType("int");

                    b.Property<int>("AdvertisementId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("CvPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MilitaryStatusId")
                        .HasColumnType("int");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementAppUserStatusId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MilitaryStatusId");

                    b.HasIndex("AdvertisementId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AdvertisementAppUsers");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AdvertisementAppUserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AdvertisementAppUserStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Başvurdu"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Mülakata Çağrıldı"
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Olumlu Sonuçlandı"
                        },
                        new
                        {
                            Id = 4,
                            Definition = "Olumsuz Sonuçlandı"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Member"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "Admin",
                            GenderId = 1,
                            Lastname = "Guest",
                            Password = "123456",
                            Phone = "12345678",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "User",
                            GenderId = 2,
                            Lastname = "Guest",
                            Password = "123456",
                            Phone = "12345678",
                            Username = "user"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppUserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AppRoleId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppRoleId = 1,
                            AppUserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AppRoleId = 2,
                            AppUserId = 2
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Erkek"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Kadın"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.MilitaryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("MilitaryStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Yaptı"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Tecilli"
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Muaf"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.ProvidedService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("ProvidedServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 31, 45, 976, DateTimeKind.Local).AddTicks(5148),
                            Description = "Web site tasarımınız için isteklerinizi alır, değerlendirir ve istekleriniz doğrultusunda eşsiz web sitenizi yapar ve internette yayınlarız. Temiz kodlanmış, hızlı ve seo uyumlu websitesi tercihi için doğru yerdesiniz.",
                            ImagePath = "~/assets/img/01.jpg",
                            Title = "Web Tasarım"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 32, 45, 976, DateTimeKind.Local).AddTicks(5639),
                            Description = "Sektörünüze uygun ios ve android mobil uygulamanızı geliştirir, play store ve app store’da yayınlarız. Uygulamanızı mobil marketler için optimize ederiz ve düzenleriz.",
                            ImagePath = "~/assets/img/02.jpg",
                            Title = "Mobil Uygulama Geliştirme"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 33, 45, 976, DateTimeKind.Local).AddTicks(5651),
                            Description = "Web siteniz için içerik yönetim paneli inşaa ederek web sitenizi web uygulamasına dönüştürür ve dinamik hale getiririz. Firma olarak üzerinde değişiklik yapabilir ve özelleştirebilirsiniz.",
                            ImagePath = "~/assets/img/03.jpg",
                            Title = "Web Uygulama Geliştirme"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 31, 45, 976, DateTimeKind.Local).AddTicks(5654),
                            Description = "Arama motoru optimizasyonu (SEO) için web sitenizin sayfa içi seo ayarlarını yapar sayfa dışında websitenizin otoritesini arttırmak için backlink ağı inşaa ederiz. Anahtar kelime takibi yapar ve sizi üst sıralara taşırız.",
                            ImagePath = "~/assets/img/01.jpg",
                            Title = "SEO"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 32, 45, 976, DateTimeKind.Local).AddTicks(5655),
                            Description = "Yazılım Geliştirmede son teknolojileri kullanır ve firmanız için gereken özel yazılımları son teknolojiler ile geliştirir ve güncelleriz. Özel yazılımlarınız için teknik destek sağlarız.",
                            ImagePath = "~/assets/img/02.jpg",
                            Title = "Özel Yazılım Geliştirme"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 12, 28, 2, 33, 45, 976, DateTimeKind.Local).AddTicks(5657),
                            Description = "Profesyonel sosyal medya ve tasarım ekibimiz ile sayfanızdaki etkileşimleri en yükseğe çıkarın.",
                            ImagePath = "~/assets/img/03.jpg",
                            Title = "Sosyal Medya Yönetimi"
                        });
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AdvertisementAppUser", b =>
                {
                    b.HasOne("Net5TestApp.Entities.Concrete.AdvertisementAppUserStatus", "AdvertisementAppUserStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementAppUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net5TestApp.Entities.Concrete.Advertisement", "Advertisement")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net5TestApp.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net5TestApp.Entities.Concrete.MilitaryStatus", "MilitaryStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("MilitaryStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advertisement");

                    b.Navigation("AdvertisementAppUserStatus");

                    b.Navigation("AppUser");

                    b.Navigation("MilitaryStatus");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppUser", b =>
                {
                    b.HasOne("Net5TestApp.Entities.Concrete.Gender", "Gender")
                        .WithMany("AppUsers")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppUserRoles", b =>
                {
                    b.HasOne("Net5TestApp.Entities.Concrete.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net5TestApp.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.Advertisement", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AdvertisementAppUserStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.AppUser", b =>
                {
                    b.Navigation("AdvertisementAppUsers");

                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.Gender", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("Net5TestApp.Entities.Concrete.MilitaryStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}