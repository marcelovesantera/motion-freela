namespace motionfreela.API.Models
{
    public class UpdateConnectionInvite : BaseModel
    {
        public bool? IsAccepted { get; set; }
        public DateTime? RepliedAt { get; set; }
    }
}
