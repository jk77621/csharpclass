using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class Ghost : Monster
    {
        public override void Init()
        {
            base.Init();
            name = "유령";
        }
    }
}
