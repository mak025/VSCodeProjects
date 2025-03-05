using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlasticFantastic
{
    public class CreditCard
    {
        string _Serial;
        string _Type;
        string _Credit;
        string _Holder;

        public CreditCard(string serial, string type, string credit, string holder)
        {

            _Serial = serial;
            _Type = type;
            _Credit = credit;
            _Holder = holder;
        }
            public CreditCard(string serial, string type)
            {
            _Serial = serial;
            _Type = type;
            }
        
        public override string ToString()
        {
            return $"This card belongs to {_Holder}, has the card type {_Type}, with a creditscore of {_Credit} and has the serial {_Serial}";
        }
    }

    
}
