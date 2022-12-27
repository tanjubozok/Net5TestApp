using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.ProvidedServiceDtos
{
    public class ProvidedServiceUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
