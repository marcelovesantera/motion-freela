namespace motionfreela.API.Models
{
    public class CreateProjectInviteModel : BaseModel
    {
        public int ProjectId { get; set; }
        public int ProjectOwnerId { get; set; }
        public int UserId { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime? RepliedAt { get; set; }
    }
}
