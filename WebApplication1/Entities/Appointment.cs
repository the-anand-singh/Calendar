using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime TimeSlot { get; set; }
    }
}
