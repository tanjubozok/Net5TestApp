using System.Collections.Generic;

namespace Net5TestApp.Entities.Concrete
{
    public class MilitaryStatus : BaseEntity
    {
        public string Definition { get; set; }

        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
