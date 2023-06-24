namespace motionfreela.API.Models
{
    public class UpdateProjectInviteModel : BaseModel
    {
        public bool? IsAccepted { get; set; }
        public DateTime? RepliedAt { get; set; }
    }
}
