using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.AppUserDtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int GenderId { get; set; }
    }
}
