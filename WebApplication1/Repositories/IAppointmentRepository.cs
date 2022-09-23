using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Entities;

namespace Calendar.Repositories
{
    public interface IAppointmentRepository
    {
        public Appointment addAppointment();
        public Appointment removeAppointment();
        public Appointment editAppointment();
        public Appointment getAllAppointments();
        public Appointment getAppointmentByDate();
        public Appointment getAppointmentsByDept();
        public Appointment getAppointmentsByDoctor();
    }
}
