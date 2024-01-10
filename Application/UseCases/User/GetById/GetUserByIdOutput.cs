using Domain.Models;

namespace Application.UseCases.User.GetById
{
    public class GetUserByIdOutput
    {
        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }
        public ResultGetUserByIdOutput? Result { get; set; }
        public GetUserByIdOutput() { }
        public GetUserByIdOutput(string? errorMessage, string? message, ResultGetUserByIdOutput? result)
        {
            ErrorMessage = errorMessage;
            Message = message;
            Result = result;
        }
    }

    public class ResultGetUserByIdOutput
    {
        public UserModel? User { get; set; }
        public ResultGetUserByIdOutput() { }
        public ResultGetUserByIdOutput(UserModel user)
        {
            User = user;
        }
    }
}
