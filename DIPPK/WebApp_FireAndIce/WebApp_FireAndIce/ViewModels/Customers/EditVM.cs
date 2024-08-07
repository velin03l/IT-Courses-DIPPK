using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp_FireAndIce.ViewModels.Customers
{
    public class EditVM
    {
        public int Id { get; set; }

        [DisplayName("Потребителско име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Username { get; set; }

        [DisplayName("Парола: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Password { get; set; }
    }
}
