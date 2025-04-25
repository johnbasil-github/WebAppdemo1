﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Entity.ViewModels
{
    public  class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    
    }
}
