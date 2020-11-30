﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
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
            Weapon.UseWeapon();
        }
    }
}
