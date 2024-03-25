namespace Zadanie3;

public class ContainerNotFound:Exception
{
    public ContainerNotFound(string? message) : base(message)
    {
    }
}