using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public string MobileNo { get; set; }
        public string BloodGroup { get; set; }

       
    }
}
