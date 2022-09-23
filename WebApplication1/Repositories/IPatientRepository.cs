using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Entities;

namespace Calendar.Repositories
{
    interface IPatientRepository
    {
        public Patient addPatient();
        public Patient removePatient();
        public Patient editPatient();
        public Patient getAllPatients();
        public Patient getPatientByName();
        public Patient getPatientsByDept();
        public Patient getPatientsByDoctor();
    }
}
