﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    public class Employee:Person
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
