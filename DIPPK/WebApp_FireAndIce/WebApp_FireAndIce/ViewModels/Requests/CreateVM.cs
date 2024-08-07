using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_FireAndIce.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp_FireAndIce.ViewModels.Requests
{
    public class CreateVM
    {
        [DisplayName("Име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Name { get; set; }

        [DisplayName("Описание: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Description { get; set; }

        [DisplayName("Адрес: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Adress { get; set; }

        /*[DisplayName("Потребителско име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public Image Image { get; set; }*/

        public int CustomerId { get; set; }
    }
}
