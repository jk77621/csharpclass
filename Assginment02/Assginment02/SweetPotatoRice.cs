using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class SweetPotatoRice : Rice
    {
        public override void Init()
        {
            name = "고구마밥";
        }

        public override int Eat()
        {
            WriteLine(name + "을 먹었다.(탄수화물 두배 증가)");
            return carbohydrate * 2;
        }

        public override int NotEat()
        {
            WriteLine(name + "을 안먹었다.(공복 절반 감소)");
            return spandrel / 2;
        }
    }
}
