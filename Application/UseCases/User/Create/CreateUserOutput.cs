namespace Application.UseCases.User.Create
{
    public class CreateUserOutput
    {
        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }
        public ResultCreateUser? Result { get; set; }

        public CreateUserOutput() { }
        public CreateUserOutput(string? errorMessage, string? message, ResultCreateUser? result)
        {
            ErrorMessage = errorMessage;
            Message = message;
            Result = result;
        }
    }
    public class ResultCreateUser
    {
        public string? UserId { get; set; }
        public ResultCreateUser() { }
        public ResultCreateUser(string? userID)
        {
            UserId = userID;
        }
    }
}
