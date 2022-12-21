using System.Collections.Generic;

namespace Net5TestApp.Entities
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public List<AppUserRoles> AppUserRoles { get; set; }
        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
