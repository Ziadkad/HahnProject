namespace Backend.Exceptions;

public class SomethingWentWrongException : Exception
{
    public SomethingWentWrongException() : base("Something went wrong While trying to do this action.")
    {
    }
}