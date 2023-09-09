namespace motionfreela.Application.InputModels
{
    public class BaseInputModel
    {
        public BaseInputModel() { }
        public int Id { get; private set; }
        public bool IsActive { get; set; }
    }
}
