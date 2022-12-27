using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;
using System;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class ProvidedServiceConfiguration : IEntityTypeConfiguration<ProvidedService>
    {
        public void Configure(EntityTypeBuilder<ProvidedService> builder)
        {
            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(500);
            builder.Property(x => x.ImagePath).IsRequired();

            builder.Property(x => x.Title).HasMaxLength(300);
            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");

            builder.HasData(new ProvidedService[]
            {
                new()
                {
                    Id= 1,
                    Title="Web Tasarım",
                    Description="Web site tasarımınız için isteklerinizi alır, değerlendirir ve istekleriniz doğrultusunda eşsiz web sitenizi yapar ve internette yayınlarız. Temiz kodlanmış, hızlı ve seo uyumlu websitesi tercihi için doğru yerdesiniz.",
                    ImagePath="assets/img/01.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(1)
                },
                new()
                {
                    Id= 2,
                    Title="Mobil Uygulama Geliştirme",
                    Description="Sektörünüze uygun ios ve android mobil uygulamanızı geliştirir, play store ve app store’da yayınlarız. Uygulamanızı mobil marketler için optimize ederiz ve düzenleriz.",
                    ImagePath="assets/img/02.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(2)
                },
                new()
                {
                    Id= 3,
                    Title="Web Uygulama Geliştirme",
                    Description="Web siteniz için içerik yönetim paneli inşaa ederek web sitenizi web uygulamasına dönüştürür ve dinamik hale getiririz. Firma olarak üzerinde değişiklik yapabilir ve özelleştirebilirsiniz.",
                    ImagePath="assets/img/03.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(3)
                },
                new()
                {
                    Id= 4,
                    Title="SEO",
                    Description="Arama motoru optimizasyonu (SEO) için web sitenizin sayfa içi seo ayarlarını yapar sayfa dışında websitenizin otoritesini arttırmak için backlink ağı inşaa ederiz. Anahtar kelime takibi yapar ve sizi üst sıralara taşırız.",
                    ImagePath="assets/img/01.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(1)
                },
                new()
                {
                    Id= 5,
                    Title="Özel Yazılım Geliştirme",
                    Description="Yazılım Geliştirmede son teknolojileri kullanır ve firmanız için gereken özel yazılımları son teknolojiler ile geliştirir ve güncelleriz. Özel yazılımlarınız için teknik destek sağlarız.",
                    ImagePath="assets/img/02.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(2)
                },
                new()
                {
                    Id= 6,
                    Title="Sosyal Medya Yönetimi",
                    Description="Profesyonel sosyal medya ve tasarım ekibimiz ile sayfanızdaki etkileşimleri en yükseğe çıkarın.",
                    ImagePath="assets/img/03.jpg",
                    CreatedDate=DateTime.Now.AddMinutes(3)
                }
            });
        }
    }
}
