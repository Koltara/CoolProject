
namespace CoolProject
{
    public class PlayerControlledObject : ActiveObject
    {
        protected bool AllowPlayerControl;

        public PlayerControlledObject()
        {
            AllowPlayerControl = true;
        }
        public PlayerControlledObject(double positionX, double positionY, int faction, bool initiallyVisible)
        {
            Instance = this;
            Visible = initiallyVisible;
            Faction = faction;

            PositionX = positionX;
            PositionY = positionY;


        }

        public void DisablePlayerControl()
        {
            AllowPlayerControl = false;
        }

        public void EnablePlayerControl()
        {
            AllowPlayerControl = true;
        }
        public void SetTargetPosition(double x, double y)
        {
            ChangePosition(x, y);
        }
    }
}

