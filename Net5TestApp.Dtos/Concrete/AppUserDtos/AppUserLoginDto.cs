using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
