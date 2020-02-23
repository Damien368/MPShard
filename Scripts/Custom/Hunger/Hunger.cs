using Server.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Commands
{
    public class Hunger
    {
        public static void Initialize()
        {
            CommandSystem.Register("Hunger", AccessLevel.Player, new CommandEventHandler(Hunger_OnCommand));
        }

        [Usage("Hunger")]
        [Description("Checks Hunger level")]
        private static void Hunger_OnCommand(CommandEventArgs e)
        {
            var from = e.Mobile;
            Mobile m = (Mobile)from;
            if (from.Hunger >= 20)
            {
                from.SendLocalizedMessage(500867); // You are simply too full to eat any more!
                //return false;
            }

            int iHunger = from.Hunger;

            if (iHunger >= 20)
            {
                from.Hunger = 20;
                from.SendMessage("You are stuffed");
            }

            else
            {
                from.Hunger = iHunger;

                if (iHunger < 5)
                    from.SendMessage("You eat the food, but are still extremely hungry"); // You eat the food, but are still extremely hungry.
                else if (iHunger < 10)
                    from.SendMessage("You eat the food, and begin to feel more satiated"); // You eat the food, and begin to feel more satiated.
                else if (iHunger < 15)
                    from.SendMessage("After eating the food, you feel much less hungry"); // After eating the food, you feel much less hungry.
                else
                    from.SendMessage("You feel quite full after consuming the food"); // You feel quite full after consuming the food.
            }

        }
    }
}
