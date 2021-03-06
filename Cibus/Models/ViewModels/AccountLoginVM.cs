﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cibus.Models.ViewModels
{
    public class AccountLoginVM
    {

        [Required(ErrorMessage = "Vänligen skriv in användarnamn")]
        [Display(Name = "Användarnamn")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vänligen skriv in lösenord (A-z/0-9)")]
        [Display(Name = "Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
