using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Net5TestApp.DataAccess.Migrations
{
    public partial class ProvidedServiceSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 30, 45, 969, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.InsertData(
                table: "ProvidedServices",
                columns: new[] { "Id", "CreatedDate", "Description", "ImagePath", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 28, 2, 31, 45, 976, DateTimeKind.Local).AddTicks(5148), "Web site tasarımınız için isteklerinizi alır, değerlendirir ve istekleriniz doğrultusunda eşsiz web sitenizi yapar ve internette yayınlarız. Temiz kodlanmış, hızlı ve seo uyumlu websitesi tercihi için doğru yerdesiniz.", "~/assets/img/01.jpg", "Web Tasarım" },
                    { 2, new DateTime(2022, 12, 28, 2, 32, 45, 976, DateTimeKind.Local).AddTicks(5639), "Sektörünüze uygun ios ve android mobil uygulamanızı geliştirir, play store ve app store’da yayınlarız. Uygulamanızı mobil marketler için optimize ederiz ve düzenleriz.", "~/assets/img/02.jpg", "Mobil Uygulama Geliştirme" },
                    { 3, new DateTime(2022, 12, 28, 2, 33, 45, 976, DateTimeKind.Local).AddTicks(5651), "Web siteniz için içerik yönetim paneli inşaa ederek web sitenizi web uygulamasına dönüştürür ve dinamik hale getiririz. Firma olarak üzerinde değişiklik yapabilir ve özelleştirebilirsiniz.", "~/assets/img/03.jpg", "Web Uygulama Geliştirme" },
                    { 4, new DateTime(2022, 12, 28, 2, 31, 45, 976, DateTimeKind.Local).AddTicks(5654), "Arama motoru optimizasyonu (SEO) için web sitenizin sayfa içi seo ayarlarını yapar sayfa dışında websitenizin otoritesini arttırmak için backlink ağı inşaa ederiz. Anahtar kelime takibi yapar ve sizi üst sıralara taşırız.", "~/assets/img/01.jpg", "SEO" },
                    { 5, new DateTime(2022, 12, 28, 2, 32, 45, 976, DateTimeKind.Local).AddTicks(5655), "Yazılım Geliştirmede son teknolojileri kullanır ve firmanız için gereken özel yazılımları son teknolojiler ile geliştirir ve güncelleriz. Özel yazılımlarınız için teknik destek sağlarız.", "~/assets/img/02.jpg", "Özel Yazılım Geliştirme" },
                    { 6, new DateTime(2022, 12, 28, 2, 33, 45, 976, DateTimeKind.Local).AddTicks(5657), "Profesyonel sosyal medya ve tasarım ekibimiz ile sayfanızdaki etkileşimleri en yükseğe çıkarın.", "~/assets/img/03.jpg", "Sosyal Medya Yönetimi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4314));
        }
    }
}
