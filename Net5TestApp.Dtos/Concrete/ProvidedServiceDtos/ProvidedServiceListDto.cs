using Net5TestApp.Dtos.Abstract;
using System;

namespace Net5TestApp.Dtos.Concrete.ProvidedServiceDtos
{
    public class ProvidedServiceListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
