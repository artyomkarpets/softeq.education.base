using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class GetUserByIdQuery : IRequest<GetUserByIdResponse>
    {
        public string UserId { get; }

        public string Id { get; }

        public GetUserByIdQuery(string userId, string id)
        {
            UserId = userId;
            Id = id;
        }
    }
}
