﻿namespace motionfreela.Application.InputModels
{
    public class CreateUserInputModel : BaseInputModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
