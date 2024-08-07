using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_FireAndIce.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp_FireAndIce.ViewModels.Customers
{
    public class CreateVM
    {
        [DisplayName("Потребителско име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Username { get; set; }

        [DisplayName("Парола: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Password { get; set; }
    }
}
