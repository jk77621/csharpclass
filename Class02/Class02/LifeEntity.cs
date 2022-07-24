using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class LifeEntity : ILifeEntity
    {
        protected int attackdamage = 0;
        protected int health = 100;

        public int Health
        {
            get
            {
                return health;
            }

            protected set
            {
                health = value;
            }
        }

        public string name = "";

        public virtual void Init()
        {
        }

        public virtual void Attack(LifeEntity lifeEntity)
        {
            lifeEntity.Hit(attackdamage);

            WriteLine(name + " : " + lifeEntity.name + "를 공격했다!");
            WriteLine(name + " : " + lifeEntity.name + "의 체력은 " + lifeEntity.Health + "이다!");
        }

        public virtual void Hit(int attackdamage)
        {
            Health -= attackdamage;

            WriteLine(name + " : " + "나는 공격당했다!");
            WriteLine(name + " : " + Health + "만큼 체력이 남았다!");
        }
    }
}
