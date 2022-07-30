using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class Rice : KoreanFood
    {
        public string name = "밥";
        public int carbohydrate = 10;
        public int spandrel = 10;

        public virtual void Init()
        {
        }

        public virtual int Eat()
        {
            WriteLine(name + "을 먹었다.(탄수화물 변화 없음)");
            return carbohydrate;
        }

        public virtual int NotEat()
        {
            WriteLine(name + "을 안먹었다.(공복 변화 없음)");
            return spandrel;
        }
    }
}
