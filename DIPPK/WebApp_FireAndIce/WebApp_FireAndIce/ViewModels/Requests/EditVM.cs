using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_FireAndIce.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp_FireAndIce.ViewModels.Requests
{
    public class EditVM
    {
        public int Id { get; set; }

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

        [DisplayName("Статус: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Status { get; set; }

        [DisplayName("Дата на посещение: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public DateTime DateOfVisit { get; set; }

        [DisplayName("ИД на техник: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public int RespTechId { get; set; }
    }
}
