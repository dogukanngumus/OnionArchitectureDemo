namespace OnionArchitectureDemo.Application.Parameters;

public class RequestParameter
{
    public RequestParameter(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }

    public int PageSize { get;}
    public int PageNumber { get; }
}