using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class MainCharacter : LifeEntity
    {
        public override void Init()
        {
            attackdamage = 10;
            Health = 100;
            name = "메인 캐릭터";
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
