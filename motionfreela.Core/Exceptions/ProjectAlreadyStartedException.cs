namespace motionfreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Project was already started.")
        {
            
        }
    }
}
