using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.MilitaryStatusDtos
{
    public class MilitaryStatusListDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
