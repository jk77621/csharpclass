using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class KoreanFood : Food
    {
        public void Guest()
        {
            WriteLine(name);
            WriteLine(price);
            // WriteLine(camefrom);

            HowMuchIsIt();

            name = "Kimchi";
            price = 3000;

            ThisFoodNameisThis();
        }

        public override void HowMuchIsIt()
        {
            base.HowMuchIsIt();
        }
    }
}
