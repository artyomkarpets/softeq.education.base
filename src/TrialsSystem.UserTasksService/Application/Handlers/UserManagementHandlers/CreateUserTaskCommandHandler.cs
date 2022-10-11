using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands;
using TrialsSystem.UserTasksService.Domain.AggregatesModel.UserTaskAggregate;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserTaskManagementHandlers
{
    public class CreateUserTaskCommandHandler : IRequestHandler<CreateUserTaskCommand, CreateUserTaskResponse>
    {
        public async Task<CreateUserTaskResponse> Handle(CreateUserTaskCommand request, CancellationToken cancellationToken)
        {
            var userTask = new UserTask(request.Name,
                                request.Status,
                                request.CreatedDateTime,
                                request.LastUpdatedDateTime,
                                request.AdditionalProperties);

            return new CreateUserTaskResponse() { Id = userTask.Id.ToString() };
        }
    }
}
