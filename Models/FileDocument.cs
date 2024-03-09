using builders_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license.Models
{
    public class FileDocument
    {
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] Content { get; set; }
        [ForeignKey("place")]
        public int PlaceId { get; set; }
        public Place place { get; set; }

    }
}
