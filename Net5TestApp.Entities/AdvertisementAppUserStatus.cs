using System.Collections.Generic;

namespace Net5TestApp.Entities
{
    public class AdvertisementAppUserStatus : BaseEntity
    {
        public string Definition { get; set; }

        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
