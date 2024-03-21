using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3_4_монетки_.Четверта_монетка__Абстракція_
{
    public class Gun : Weapon
    {
        public int Ammunition { get; set; } = 10;
        public override void MakeDamage(People persone)
        {
            if(Ammunition <= 0)
            {
                Recharge();
                return;
            }
            if(persone.Health < 50)
            {
                Console.WriteLine("Persone is died");
                Ammunition--;
                return;

            }
            persone.Health -= 50;
            Ammunition--;
        }

        public void Recharge()
        {
            Ammunition += 5;
        }
    }
}
