﻿namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class UpdateUserRequest
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        public string CityId { get; set; }
    }
}
