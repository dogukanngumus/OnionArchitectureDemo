namespace OnionArchitectureDemo.Application.Wrappers;

public class ServiceResponse<T>
{
    public T Value { get; set; }

    public ServiceResponse(T value)
    {
        Value = value;
    }
}