using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builders_Project.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }
        public string Shift { get; set; }
        
        [MinLength(11)]
        public string Phone { get; set; }
    }
}
