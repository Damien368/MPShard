using System;
using Server;
using Server.Network;
using Server.Items;
using System.Collections.Generic;
using Server.Accounting;
using Server.Mobiles;
using Server.Gumps;
using Server.Targeting;

namespace Server.Gumps
{
    public class QuipGump : Gump
    {
        //public int []equippables;
        public Item quipBag;


        public QuipGump()
            : base(0, 0)
        {
            
            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;
            this.AddPage(0);
            this.AddBackground(6, 6, 317, 341, 9200);
            this.AddLabel(132, 19, 54, @"Quip Lists");
            this.AddButton(239, 306, 247, 248, 0, GumpButtonType.Reply, 0);
            this.AddButton(24, 64, 2501, 2501, 1, GumpButtonType.Reply, 0);
            this.AddLabel(37, 64, 0, @"Set Current Quip");
            this.AddButton(23, 103, 2501, 2501, 2, GumpButtonType.Reply, 0);
            this.AddLabel(36, 103, 0, @"Set Current Quip2");
            this.AddButton(22, 143, 2501, 2501, 3, GumpButtonType.Reply, 0);
            this.AddLabel(35, 143, 0, @"Set Current Quip3");
            this.AddButton(23, 185, 2501, 2501, 4, GumpButtonType.Reply, 0);
            this.AddLabel(36, 185, 0, @"Set Current Quip4");
            this.AddLabel(188, 64, 0, @"[Quip1");
            this.AddLabel(188, 105, 0, @"[Quip2");
            this.AddLabel(188, 146, 0, @"[Quip3");
            this.AddLabel(188, 186, 0, @"[Quip4");
            this.AddLabel(20, 226, 0, @"To Unequip Everything type [Quip0 ");
            this.AddButton(24, 276, 2501, 2501, 5, GumpButtonType.Reply, 0);
            this.AddLabel(55, 276, 0, @"Set Quip Bag");

        }

        public enum Buttons
        {
            Button1,
            Quip1Button,
            Quip2Button,
            Quip3Button,
            Quip4Button,
            SetBagButton,
        }
        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile from = state.Mobile;
            Account acc = from.Account as Account;
            var parent = from;
            Mobile m = parent;
            Container pack = m.Backpack;
            //var missing = false;
            var pm = parent as PlayerMobile;
            switch (info.ButtonID)
            {
                case 0:
                    break;
                case 1:
                    // m.SendMessage("Got into Case");
                    if (m.Alive)
                    {
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Arms));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Bracelet));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Cloak));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Earrings));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Gloves));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Helm));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.InnerLegs));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.InnerTorso));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.MiddleTorso));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Neck));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.OneHanded));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.OuterLegs));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.OuterTorso));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Pants));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Ring));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Shirt));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Shoes));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Talisman));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.TwoHanded));
                        pm.QuipList.Add(m.FindItemOnLayer(Layer.Waist));
                        //foreach (var i in pm.QuipList)
                        //{
                        //    if (i != null)
                        //        m.SendMessage(i.ToString());
                        //}
                        m.SendMessage("Quip List 1 Set!");
                    }
                    else m.SendMessage("You are dead and cannot wear anything!");
            
                    break;
                case 2:
                    if (m.Alive)
                    {
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Arms));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Bracelet));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Cloak));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Earrings));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Gloves));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Helm));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.InnerLegs));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.InnerTorso));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.MiddleTorso));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Neck));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.OneHanded));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.OuterLegs));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.OuterTorso));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Pants));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Ring));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Shirt));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Shoes));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Talisman));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.TwoHanded));
                        pm.QuipList2.Add(m.FindItemOnLayer(Layer.Waist));
                        m.SendMessage("Quip List 2 Set!");
                    }
                    else m.SendMessage("You are dead and cannot wear anything!");
                    break;
                case 3:
                    if (m.Alive)
                    {
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Arms));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Bracelet));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Cloak));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Earrings));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Gloves));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Helm));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.InnerLegs));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.InnerTorso));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.MiddleTorso));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Neck));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.OneHanded));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.OuterLegs));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.OuterTorso));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Pants));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Ring));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Shirt));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Shoes));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Talisman));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.TwoHanded));
                        pm.QuipList3.Add(m.FindItemOnLayer(Layer.Waist));
                        m.SendMessage("Quip List 3 Set!");
                    }
                    else m.SendMessage("You are dead and cannot wear anything!");
                    break;
                case 4:
                    if (m.Alive)
                    {
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Arms));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Bracelet));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Cloak));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Earrings));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Gloves));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Helm));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.InnerLegs));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.InnerTorso));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.MiddleTorso));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Neck));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.OneHanded));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.OuterLegs));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.OuterTorso));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Pants));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Ring));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Shirt));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Shoes));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Talisman));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.TwoHanded));
                        pm.QuipList4.Add(m.FindItemOnLayer(Layer.Waist));
                        m.SendMessage("Quip List 4 Set!");
                    }
                    else m.SendMessage("You are dead and cannot wear anything!");
                    break;
                case 5:

                    //target bag
                    if (m.Alive)
                    {
                        m.Target = new InternalTarget();
                    }
                    else m.SendMessage("You are dead and cannot carry anything!");
                    break;
            }
        }

        public static TimeSpan OnUse(Mobile from)
        {
            from.SendMessage("Which Bag do you want to use for your Equipment?");
            from.Target = new InternalTarget();

            return TimeSpan.FromSeconds(1.0);
        }

        private class InternalTarget : Target
        {
            public InternalTarget()
                : base(8, false, TargetFlags.None)
            {
                this.AllowNonlocal = true;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                Container quipBag = o as Container;
                var parent = from;
                Mobile m = parent;
                Container pack = m.Backpack;
                var pm = parent as PlayerMobile;
                pm.QuipBag = quipBag;
                m.SendMessage("Quip Bag Set!");

            }

        }
    }
}
