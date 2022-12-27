using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.AppRoleDtos
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
