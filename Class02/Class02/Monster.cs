using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class Monster : LifeEntity
    {
        public override void Init()
        {
            attackdamage = 3;
            Health = 50;
            name = "몬스터";
        }

        public override void Attack(LifeEntity lifeEntity)
        {
            base.Attack(lifeEntity);
        }

        public override void Hit(int attackedamage)
        {
            base.Hit(attackedamage);
        }
    }
}
