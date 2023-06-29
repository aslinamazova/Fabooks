namespace Core.Utilities.Exceptions;

public class AlreadyIsExistsException:Exception
{
    public AlreadyIsExistsException(string message):base(message){}
    public AlreadyIsExistsException():base("Entity already exists!"){}
}
