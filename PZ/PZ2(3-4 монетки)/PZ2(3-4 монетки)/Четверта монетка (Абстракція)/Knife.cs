using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3_4_монетки_.Четверта_монетка__Абстракція_
{
    public class Knife : Weapon
    {
        public override void MakeDamage(People persone)
        {
            if(persone.Health < 30)
            {
                Console.WriteLine("Persone is died");
                return;
            }
            persone.Health -= 30;
        }
    }
}
