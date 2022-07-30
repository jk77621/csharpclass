using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class SideDish : KoreanFood
    {
        public string name = "반찬";
        public int calorie = 10;
        public int happiness = 10;

        public virtual void Init()
        {
        }

        public virtual int Eat()
        {
            WriteLine(name + "을 먹었다.(칼로리 변화 없음)");
            return calorie;
        }

        public virtual int NotEat()
        {
            WriteLine(name + "을 안먹었다.(행복도 변화 없음)");
            return happiness;
        }
    }
}
