using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAQ_BackendDev.API.Models
{
    public class Login_DTO
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
