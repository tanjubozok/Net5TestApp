using Microsoft.AspNetCore.Mvc.Rendering;

namespace Net5TestApp.WebUI.Models
{
    public class UserCreateModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
        public int GenderId { get; set; }
        public SelectList Genders { get; set; }
    }
}
