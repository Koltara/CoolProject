
namespace CoolProject
{
    public class ActiveObject
    {
        public static ActiveObject Instance;

        protected bool Visible;

        protected int Faction;
        protected double PositionX;
        protected double PositionY;

        public ActiveObject()
        {
            Instance = this;
            Visible = true;
            Faction = 0;

            PositionX = 0;
            PositionY = 0;
        }
        public ActiveObject(double positionX, double positionY, int faction, bool initiallyVisible)
        {
            Instance = this;
            Visible = initiallyVisible;
            Faction = faction;

            PositionX = positionX;
            PositionY = positionY;

        }
        public void ChangePosition(double x, double y)
        {
            PositionX = x;
            PositionY = y;
        }

        public double GetPositionX()
        {
            return PositionX;
        }

        public double GetPositionY()
        {
            return PositionY;
        }


    }
}


