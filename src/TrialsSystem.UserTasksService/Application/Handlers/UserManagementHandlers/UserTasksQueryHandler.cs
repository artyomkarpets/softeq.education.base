using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries.UserTaskManagementQueries;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserTaskManagementHandlers
{
    public class GetUserTasksQueryHandler : IRequestHandler<GetUserTasksQuery, IEnumerable<GetUserTaskResponse>>
    {
        public GetUserTasksQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUserTaskResponse>> Handle(GetUserTasksQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUserTaskResponse>();
        }
    }
}
