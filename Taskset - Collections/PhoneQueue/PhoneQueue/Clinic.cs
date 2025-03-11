using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneQueue
{
    class Clinic
    {
        private Queue<Patient> waitingQueue;


        public Clinic()
        {
            waitingQueue = new Queue<Patient>();
        }
    }
}
