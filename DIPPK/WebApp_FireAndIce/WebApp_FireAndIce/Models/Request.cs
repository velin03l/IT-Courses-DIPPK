using System;
using System.Collections.Generic;
using System.Linq;
//using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_FireAndIce.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        //public Image Image { get; set; }
        public string Status { get; set; }
        public DateTime DateOfVisit { get; set; }
        public Tech RespTech { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
    }
}
