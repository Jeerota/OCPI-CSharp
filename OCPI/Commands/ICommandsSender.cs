namespace OCPI.Commands
{
    public interface ICommandsSender
    {
        //GET Request
        CommandResult IssueCommand(CommandType commandType);
    }
}
