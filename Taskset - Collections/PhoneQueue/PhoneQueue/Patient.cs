using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneQueue
{
    public class Patient
    {
        private string _name;                   // Stores the patients name
        private string _need;                   // Stores the patients need
        private DateTime _contactTime;          // Stores the time of which the patient called

        public Patient(string name, string need, DateTime contactTime)
        {
                                                // Below is what makes sure the various properties given to the object is stored upon construction
            _name = name;                       // Assigsn the value (name) to the field (_name)
            _need = need;                       // Assigns the value (need) to the field (_need)
            _contactTime = contactTime;         // Assigns the value (contactTime) to the field (_contactTime)
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Need
        {
            get { return _need; }
            set { _need = value; }
        }

        public DateTime ContactTime
        {
            get { return _contactTime; }
            set { _contactTime = value; }
        }

        public override string ToString()
        {
            return $"Patient: {_name}, Need: {_need}, Contacted at: {_contactTime}";
        }
    }
}
