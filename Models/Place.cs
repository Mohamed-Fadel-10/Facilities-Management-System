using license.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace builders_Project.Models
{
    public class Place
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Expired { get {return AA(); } } 
        public string Address { get; set; }
        public DateTime license_Start_Date { get; set; }

        public DateTime license_End_Date { get; set; }
        [ForeignKey("classification")]
        public string Classification_ID { get; set; }
        public string Status { get; set; }
        public clsssification classification { get; set; }
        
        public string? Code { get; set; }
        public string Description { get; set; }
        public List<FileDocument> Files { get; set; }

        public string AA()
        {
            if (license_End_Date>=DateTime.Now )
            {
                return "سارية";
            }
            return "منتهية";
        }

    }
}
