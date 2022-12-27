using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Net5TestApp.DataAccess.Migrations
{
    public partial class Adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1255), "C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış", true, "Yazılım Uzmanı" },
                    { 2, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1567), "Üniversitelerin Mühendislik bölümlerinden mezun,\r\nEn az 2 yıl profesyonel iş tecrübesi olan,\r\nAskerlik hizmetini tamamlamış,\r\nAngular ve Typescript teknolojilerini kullanarak proje geliştirmiş,\r\nWeb API, LINQ, Entity Framework ve MSSQL bilgisi olan,\r\nC#, .NET Core bilgisi ve. NET Teknolojilerine hakim,\r\nVersiyon kontrol sistemleri (TFS, GIT) konusunda bilgi sahibi,\r\nTakım çalışmasına yatkın ve birlikte çalışmanın yarattığı sinerjinin farkında olan,\r\nİş takibi kuvvetli,\r\nTeknoloji ve yenilikleri takip edebilen,\r\nÖğrenmeye ve gelişmeye açık", true, ".Net Core / Angular Yazılım Geliştirme Uzmanı" },
                    { 3, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1570), "Proje deneyimi olan,\r\nVeritabanı mimarilerine hakim,\r\nServis yapıları konusunda tecrübeleri,\r\nPHP dili ve codeigniter üzerinde master seviyede ve MVC yapıları hakkında bilgi sahibi,\r\nEn az 5 yıl tecrübeli,\r\nLinux sunucular üzerinde PHP geliştirmiş,\r\nTakım çalışmasına ve ekip ruhuna uyum sağlayabilen,\r\nEn az 3 sene tecilli veya askerliğini bitirmiş,\r\nJetBrains araçlarını kullanabilen,\r\nVersiyon yönetimi konusunda tecrübeli", true, "Back End Developer" },
                    { 4, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1572), "Tercihen üniversitelerin Bilgisayar Mühendisliği, Yazılım Mühendisliği, Bilgisayar Programcılığı ya da benzer bölümlerden mezun,\r\nMinimum 3 yıl .NET teknolojileriyle (C#, ASP) yazılım geliştirmesi tecrübesi olan,\r\nMicrosoft SQL Server tecrübesi olan, (View, Stored Procedure, SQL/TSQL)\r\nTercihen Web Service , Web Api geliştirmiş olan,\r\nTercihen HTML, CSS, Javascript bilgisine sahip\r\nKurumsal uygulamaların tasarım, implemantasyon, test, performans izleme, dokümantasyon tecrübesine sahip,\r\nTeknik dokümanları anlayabilecek seviyede İngilizce bilen,\r\nAnalitik düşünce ve problem çözme becerisi kuvvetli, iletişim yönü güçlü, değişime, yeni teknolojilere ve gelişmeye açık,\r\nErkek adaylar için askerliğini tamamlamış,", true, ".Net Yazılım Uzmanı" },
                    { 5, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1574), "C# programlama diline hakim,\r\nMS SQL orta seviyede bilgi sahibi olan,\r\nWeb uygulamaları geliştirmiş,\r\nGüncel web teknolojilerini takip eden,\r\nAnalitik düşünebilen ve problem çözme becerisi yüksek,\r\nTercihen eBA -CSP İş Akış Yönetim Sistemi projelerinin analiz, tasarım ve geliştirme süreçlerinde görev almış", true, "Yazılım Uzmanı" },
                    { 6, new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1577), "NET ve MSSQL konularında uzman,\r\nFront End ve Back End deneyimi bulunan,\r\nSEO optimizasyonları konusunda bilgi sahibi,\r\nNET platformunda Object Oriented programlama tecrübesine sahip,\r\nVB.NET dilinde kodlama yapmış, VB.NET diline hakim, C#.NET ile ilgili bilgi sahibi,\r\nHTML 5, CSS, Javascript, Ajax, CRM, Php, Headless, Hubspot konularında bilgi sahibi,\r\nİçerik yönetim sistemleri hakkında bilgi sahibi,\r\nSQL Server konusunda deneyimi olan,\r\nWeb uygulamaları geliştirmiş adayların başvurularını bekliyoruz.", true, "Yazılım Uzmanı" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Definition" },
                values: new object[,]
                {
                    { 1, "Erkek" },
                    { 2, "Kadın" }
                });

            migrationBuilder.InsertData(
                table: "MilitaryStatuses",
                columns: new[] { "Id", "Definition" },
                values: new object[,]
                {
                    { 1, "Yaptı" },
                    { 2, "Tecilli" },
                    { 3, "Muaf" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Firstname", "GenderId", "Lastname", "Password", "Phone", "Username" },
                values: new object[] { 1, "Admin", 1, "Guest", "123456", "12345678", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Firstname", "GenderId", "Lastname", "Password", "Phone", "Username" },
                values: new object[] { 2, "User", 2, "Guest", "123456", "12345678", "user" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "Id", "AppRoleId", "AppUserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "Id", "AppRoleId", "AppUserId" },
                values: new object[] { 2, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MilitaryStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MilitaryStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MilitaryStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
