namespace motionfreela.API.Models
{
    public class CreateUserModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? RoleTitle { get; set; }
        public string? Description { get; set; }
        public string? PersonalSite { get; set; }
        public string? Linkedin { get; set; }
        public string? Behance { get; set; }
        public string? Youtube { get; set; }
        public string? Vimeo { get; set; }
        public string? Dribbble { get; set; }
    }
}
