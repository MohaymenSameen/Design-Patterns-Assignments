using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public abstract class Character
    {
        private IWeaponBehaviour weapon;
        public IWeaponBehaviour Weapon
        { 
            get { return weapon; }
            set { weapon = value; }
        }        
        public Character()
        {
            weapon = new SwordBehaviour();
        }        
        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
