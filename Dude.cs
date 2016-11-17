using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace CoolProject
{
    public class Dude : Hero
    {
        private const string DisplayName = "Dude";
        public Dude()
        {
            MaxHealth = 150;
            CurrentHealth = MaxHealth;

            AttackPower = 35;

            SpellPower = 55;

            MovementSpeed = 300;
        }

        public string GetHeroName()
        {
            return DisplayName;
        }
    }
}
