using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}
