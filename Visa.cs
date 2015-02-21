using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContrainer
{
    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Chaaaarging with the Visa";
        }
    }
}
