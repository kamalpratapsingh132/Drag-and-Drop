using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drag_and_Drop.Models
{
    public class Add_Pateint
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string pateintType { get; set; }
    }
}
