﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationUserInterface.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Skillset { get; set; }
        public string Hobby { get; set; }

    }
}