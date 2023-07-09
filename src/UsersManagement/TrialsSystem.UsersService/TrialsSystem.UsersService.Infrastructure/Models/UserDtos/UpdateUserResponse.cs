﻿namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class UpdateUserResponse
    {
        public UpdateUserResponse(string id, string name, string surname, DateTime birthDate, decimal? weight, decimal? height, string cityId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            CityId = cityId;
        }
        public string Id { get; }

        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public decimal? Weight { get; }
        public decimal? Height { get; }
        public string CityId { get; }
    }
}
