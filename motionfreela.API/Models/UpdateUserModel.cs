namespace motionfreela.API.Models
{
    public class UpdateUserModel : BaseModel
    {
        public string? Username { get; set; }
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
