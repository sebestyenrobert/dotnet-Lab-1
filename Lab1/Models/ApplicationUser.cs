﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Rental> Rentals { get; set; }
    }
}
