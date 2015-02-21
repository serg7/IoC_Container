using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Resolver resolver = new Resolver();
            resolver.Register<Shopper, Shopper>();
            resolver.Register<ICreditCard, MasterCard>();

            var shopper = resolver.Resolve<Shopper>();
            shopper.Charge();

            Console.Read();
        }
    }

}
