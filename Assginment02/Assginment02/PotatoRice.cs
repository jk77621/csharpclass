using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class PotatoRice : Rice
    {
        public override void Init()
        {
            name = "감자밥";
        }

        public override int Eat()
        {
            WriteLine(name + "을 먹었다.(탄수화물 절반 감소)");
            return carbohydrate / 2;
        }
    }
}
