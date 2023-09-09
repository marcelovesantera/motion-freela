namespace motionfreela.Application.InputModels
{
    public class CreateProjectInputModel : BaseInputModel
    {
        public int OwnerId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; set; }
    }
}
