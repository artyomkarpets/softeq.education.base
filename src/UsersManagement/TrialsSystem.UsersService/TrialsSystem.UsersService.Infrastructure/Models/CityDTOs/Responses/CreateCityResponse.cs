using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.Requests;

namespace TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.Responses
{
    public class CreateCityResponse : CreateCityRequest
    {
        public string Id { get; set; }
    }
}