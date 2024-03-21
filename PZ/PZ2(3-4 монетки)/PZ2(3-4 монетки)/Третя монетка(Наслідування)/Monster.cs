using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZ2_3_4_монетки_.Четверта_монетка__Абстракція_;

namespace PZ2_3_4_монетки_.Третя_монетка_Наслідування_
{
    public class Monster
    {
        public int Health { get; set; } = 100;
        public string Name { get; set; }
        public int Anger { get; set; } = 100;

        public Monster(string name) 
        {
            Name = name;
        }

        public void Hit(People people)
        {
            people.Health -= 5;
        }
    }
}
