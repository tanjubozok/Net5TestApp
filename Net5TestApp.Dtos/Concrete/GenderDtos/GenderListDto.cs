using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.GenderDtos
{
    public class GenderListDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
