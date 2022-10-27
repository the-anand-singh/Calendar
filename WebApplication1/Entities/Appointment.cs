using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime TimeSlot { get; set; }
    }
}
