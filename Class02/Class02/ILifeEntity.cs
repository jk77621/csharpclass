using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    interface ILifeEntity
    {
        void Attack(LifeEntity lifeEntity);
        void Hit(int attackdamage);
    }
}
