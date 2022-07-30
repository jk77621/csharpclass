using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class MeatSideDish : SideDish
    {
        public override void Init()
        {
            name = "고기반찬";
        }

        public override int Eat()
        {
            WriteLine(name + "을 먹었다.(칼로리 절반 감소)");
            return calorie / 2;
        }
    }
}
