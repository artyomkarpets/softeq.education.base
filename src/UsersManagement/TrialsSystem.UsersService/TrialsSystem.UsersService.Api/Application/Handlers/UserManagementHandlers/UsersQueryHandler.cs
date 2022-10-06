using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserManagementHandlers
{
    public class UsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<GetUsersResponse>>
    {
        public UsersQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUsersResponse>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUsersResponse>();
        }
    }
}
