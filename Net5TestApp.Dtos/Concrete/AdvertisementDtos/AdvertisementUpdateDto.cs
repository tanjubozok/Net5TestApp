using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.AdvertisementDtos
{
    public class AdvertisementUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}
