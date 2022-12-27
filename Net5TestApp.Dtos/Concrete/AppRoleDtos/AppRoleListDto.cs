using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.AppRoleDtos
{
    public class AppRoleListDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
