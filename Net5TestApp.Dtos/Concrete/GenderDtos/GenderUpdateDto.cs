using Net5TestApp.Dtos.Interfaces;

namespace Net5TestApp.Dtos.Concrete.GenderDtos
{
    public class GenderUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
