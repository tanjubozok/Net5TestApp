using System.Collections.Generic;

namespace Net5TestApp.Entities
{
    public class Gender : BaseEntity
    {
        public string Definition { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
