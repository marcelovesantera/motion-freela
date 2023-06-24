namespace motionfreela.API.Models
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Status { get; set; }
        public bool IsActive { get; set; }
    }
}
