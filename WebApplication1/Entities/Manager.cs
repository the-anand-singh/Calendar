using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    [Table("Manager")]
    public class Manager
    {
        [Key]
        public string ManagerID { get; set; }
        public string ManagerPassword { get; set; }
        
    }

}
