using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContrainer
{
    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            return "Swiping the MasterCard";
        }
    }
}
