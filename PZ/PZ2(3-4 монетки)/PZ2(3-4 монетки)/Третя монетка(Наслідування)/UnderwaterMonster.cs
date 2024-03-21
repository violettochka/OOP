using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3_4_монетки_.Третя_монетка_Наслідування_
{
    public class UnderwaterMonster : Monster
    {
        public UnderwaterMonster(string name) : base(name) { }

        public void CanSwim()
        {
            Console.WriteLine("Monster can swim");
        }
    }
}
