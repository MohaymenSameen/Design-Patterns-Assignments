using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}
