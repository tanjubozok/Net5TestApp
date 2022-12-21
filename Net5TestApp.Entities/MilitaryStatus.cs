using System.Collections.Generic;

namespace Net5TestApp.Entities
{
    public class MilitaryStatus : BaseEntity
    {
        public string Definition { get; set; }

        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
