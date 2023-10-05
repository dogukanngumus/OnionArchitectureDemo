namespace OnionArchitectureDemo.Application.Exceptions;

public class ValidationException : Exception
{
    public ValidationException() : this("Validation error occured.")
    {
    }

    public ValidationException(string message) : base(message)
    {
    }

    public ValidationException(String message, Exception ex): base(message, ex)
    {
    }
}