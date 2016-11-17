
namespace CoolProject
{
    public class Hero : PlayerControlledObject
    {
        protected int CurrentHealth;
        protected int MaxHealth;
        protected int HealthAddMod;
        protected double HealthMultMod;

        protected int AttackPower;
        protected int AttackPowerAddMod;
        protected double AttackPowerMultMod;

        protected int SpellPower;
        protected int SpellPowerAddMod;
        protected double SpellPowerMultMod;

        protected int MovementSpeed;
        protected int MovementSpeedAddMod;
        protected double MovementSpeedMultMod;


        public Hero()
        {
            MaxHealth = 50;
            CurrentHealth = MaxHealth;
            HealthAddMod = 0;
            HealthMultMod = 1.0;

            AttackPower = 25;
            AttackPowerAddMod = 0;
            AttackPowerMultMod = 1.0;

            SpellPower = 25;
            SpellPowerAddMod = 0;
            SpellPowerMultMod = 1.0;

            MovementSpeed = 300;
            MovementSpeedAddMod = 0;
            MovementSpeedMultMod = 1.0;
        }

        public void SetMaxHealth(int value)
        {
            MaxHealth = value;
        }

        public int GetMaxHealth(int value)
        {
            return MaxHealth;
            
        }

        public void SetCurrentHealth(int value)
        {
            CurrentHealth = value;
        }

        public void AddToCumulativeHealthModifier(int value)
        {
            HealthAddMod += value;
        }

        public int GetCumulativeHealthModifier()
        {
            return HealthAddMod;
        }

        public void AddToMultiplicativeHealthModifier(double value)
        {
            HealthMultMod += value;
        }

        public double GetMultiplicativeHealthModifier()
        {
            return HealthMultMod;
        }

        public int GetAttackPower()
        {
            return AttackPower;
        }

        public void SetAttackPower(int value)
        {
            AttackPower = value;
        }

        public void AddToCumulativeAttackPowerModifier(int value)
        {
            AttackPowerAddMod += value;
        }

        public void AddToMultiplicativeAttackPowerModifier(int value)
        {
            AttackPowerMultMod += value;
        }

        public int GetSpellPower()
        {
            return SpellPower;
        }

        public void SetSpellPower(int value)
        {
            SpellPower = value;
        }

        public void AddToCumulativeSpellPowerModifier(int value)
        {
            SpellPowerAddMod += value;
        }

        public void AddToMultiplicativeSpellPowerModifier(int value)
        {
            SpellPowerMultMod += value;
        }

        public void SetMovementSpeed(int value)
        {
            MovementSpeed = value;
        }

        public int GetMovementSpeed()
        {
            return MovementSpeed;
        }

        public void AddToCumulativeMovementSpeedModifier(int value)
        {
            MovementSpeedAddMod += value;
        }

        public void AddToMultiplicativeMovementSpeedModifier(int value)
        {
            MovementSpeedMultMod += value;
        }
    }
}
