﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialsSystem.UsersService.Infrastructure.Models.BaseDTO;

namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class GetUserByIdResponse
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        public IdNameDto City { get; set; }
       
        public IdNameDto Gender { get; set; }

    }
}