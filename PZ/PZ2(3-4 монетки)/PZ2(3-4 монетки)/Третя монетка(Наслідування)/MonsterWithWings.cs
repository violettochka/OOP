using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3_4_монетки_.Третя_монетка_Наслідування_
{
    public class MonsterWithWings : Monster
    {
        public MonsterWithWings(string name) : base(name) { }

        public void CanFly()
        {
            Console.WriteLine("Monster can fly");
        }
    }
}
