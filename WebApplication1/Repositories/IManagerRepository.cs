using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Entities;

namespace Calendar.Repositories
{
    interface IManagerRepository
    {
        public Manager addManager();
        public Manager removeManager();
        public Manager editManager();
        public Manager getAllManagers();
        public Manager getManagerByName();
    }
}
