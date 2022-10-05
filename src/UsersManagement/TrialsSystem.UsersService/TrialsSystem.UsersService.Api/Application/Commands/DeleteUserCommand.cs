namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class DeleteUserCommand
    {
        public string Id { get; private set; }

        public DeleteUserCommand(string id)
        {
            Id = id;
        }
    }
}
