﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos.UserDTO
{
    public class CreateUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string Nickname { get; set; }
    }
}
