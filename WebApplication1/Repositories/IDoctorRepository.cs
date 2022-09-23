using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Entities;

namespace Calendar.Repositories
{
    public interface IDoctorRepository
    {
        public Doctor addDoctor();
        public Doctor removeDoctor();
        public Doctor editDoctor();
        public Doctor getAllDoctors();
        public Doctor getDoctorByName();
        public Doctor getDoctorsByDept();


    }
}
