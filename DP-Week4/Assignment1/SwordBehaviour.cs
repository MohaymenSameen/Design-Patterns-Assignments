using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
