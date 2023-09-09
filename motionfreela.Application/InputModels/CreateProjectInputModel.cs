namespace motionfreela.Application.InputModels
{
    public class CreateProjectInputModel : BaseInputModel
    {
        public int OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
