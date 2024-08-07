using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_FireAndIce.Models
{
    public class Tech
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public List<Request> Requests { get; set; }
    }
}
