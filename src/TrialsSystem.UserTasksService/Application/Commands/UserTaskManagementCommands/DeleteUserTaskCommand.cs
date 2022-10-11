namespace TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands
{
    public class DeleteUserTaskCommand
    {
        public string Id { get; private set; }

        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }
    }
}
