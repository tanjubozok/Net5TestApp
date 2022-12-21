using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.ProvidedServiceDtos
{
    public class ProvidedServiceCreateDto : IDto
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
