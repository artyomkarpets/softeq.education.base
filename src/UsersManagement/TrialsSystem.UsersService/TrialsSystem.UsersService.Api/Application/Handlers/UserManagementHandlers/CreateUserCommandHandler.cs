using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserManagementHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
    {
        public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return new CreateUserResponse();
        }
    }
}
