namespace motionfreela.API.Models
{
    public class CreateConnectionInvite : BaseModel
    {
        public int InvitationOwnerId { get; set; }
        public int UserId { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime? RepliedAt { get; set; }
    }
}
