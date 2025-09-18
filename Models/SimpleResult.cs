namespace EmployeeAdminPortal.Models;

public class SimpleResult<T>
{
    public bool IsSuccess { get; private set; }
    public T? Data { get; private set; }
    public string? ErrorCode { get; private set; }
    public string? Description { get; private set; }
    public bool Retryable { get; private set; }

    public SimpleResult()
    {
    }

    public static SimpleResult<T> FromSuccess(T data)
    {
        return new SimpleResult<T> { IsSuccess = true, Data = data };
    }

    public static SimpleResult<T> FromError(string errorCode, string description, bool retryable)
    {
        return new SimpleResult<T>()
        {
            IsSuccess = false,
            ErrorCode = errorCode,
            Description = description,
            Retryable = retryable
        };
    }
}
