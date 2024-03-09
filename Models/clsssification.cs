using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices;
namespace builders_Project.Models
{
    public class clsssification
    {
        [Key]
        public string Code {get; set;}
        public string Name { get; set; }
        public override string ToString()
        {
            return Code;
        }

    }
}