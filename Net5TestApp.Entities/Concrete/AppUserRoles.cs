namespace Net5TestApp.Entities.Concrete
{
    public class AppUserRoles : BaseEntity
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
