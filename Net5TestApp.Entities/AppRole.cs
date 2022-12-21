using System.Collections.Generic;

namespace Net5TestApp.Entities
{
    public class AppRole : BaseEntity
    {
        public string Definition { get; set; }

        public List<AppUserRoles> AppUserRoles { get; set; }
    }
}
