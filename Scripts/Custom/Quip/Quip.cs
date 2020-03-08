using Server.Items;
using Server.Mobiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Commands
{
    public class Quip
    {
        public static void Initialize()
        {
            CommandSystem.Register("Quip", AccessLevel.Player, new CommandEventHandler(Quip_OnCommand));
            CommandSystem.Register("Quip1", AccessLevel.Player, new CommandEventHandler(Quip1_OnCommand));
            CommandSystem.Register("Quip2", AccessLevel.Player, new CommandEventHandler(Quip2_OnCommand));
            CommandSystem.Register("Quip3", AccessLevel.Player, new CommandEventHandler(Quip3_OnCommand));
            CommandSystem.Register("Quip4", AccessLevel.Player, new CommandEventHandler(Quip4_OnCommand));
            CommandSystem.Register("Quip0", AccessLevel.Player, new CommandEventHandler(Quip0_OnCommand));
        }

        [Usage("Quip")]
        [Description("Displays Quip Gump.")]
        public static void Quip_OnCommand(CommandEventArgs e)
        {
                var parent = e.Mobile;
                Mobile m = (Mobile)parent;
                 Container pack = m.Backpack;
            if (m.Alive)
                m.SendGump(new Gumps.QuipGump());
            else m.SendMessage("You are dead and cannot do that");
        }

        [Usage("Quip4")]
        [Description("Equips Quip List 4.")]
        public static void Quip4_OnCommand(CommandEventArgs e)
        {
            //var msgSent = false;
            var parent = e.Mobile;
            Mobile m = (Mobile)parent;
            var pm = m as PlayerMobile;
            Container pack = m.Backpack;
            var count = pm.QuipList4.Count;
            Quip0_OnCommand(e); //quip0 called because else the character won't unequip already equipped items.
            if (count == 0)
            {
                m.SendMessage("Nothing in Quip List 4!");
            }
            else foreach (var i in pm.QuipList4)
            {
                    if (pm.Alive)
                    {
                        //if (msgSent == false && (!pack.Items.Contains(i)) || (!pack.Items.Contains(pm.QuipBag)))
                        //{
                        //    m.SendMessage("Some of your equipment is no longer in your pack!");
                        //    msgSent = true;
                        //}
                        if (i != null && (pack.Items.Contains(i) || pack.Items.Contains(pm.QuipBag)))
                            pm.EquipItem(i);

                    }
                    else m.SendMessage("You are dead and cannot equip anything!");
                }
        }

        [Usage("Quip3")]
        [Description("Equips Quip List 3.")]
        public static void Quip3_OnCommand(CommandEventArgs e)
        {
            //var msgSent = false;
            var parent = e.Mobile;
            Mobile m = (Mobile)parent;
            var pm = m as PlayerMobile;
            Container pack = m.Backpack;
            var count = pm.QuipList3.Count;
            Quip0_OnCommand(e); //quip0 called because else the character won't unequip already equipped items.
            if (count == 0)
            {
                m.SendMessage("Nothing in Quip List 3!");
            }
            else foreach (var i in pm.QuipList3)
            {

                    if (pm.Alive)
                    {
                        //if (msgSent == false && (!pack.Items.Contains(i)) || (!pack.Items.Contains(pm.QuipBag)))
                        //{
                        //    m.SendMessage("Some of your equipment is no longer in your pack!");
                        //    msgSent = true;
                        //}
                        if (i != null && (pack.Items.Contains(i) || pack.Items.Contains(pm.QuipBag)))
                            pm.EquipItem(i);

                    }
                    else m.SendMessage("You are dead and cannot equip anything!");
                }
        }

        [Usage("Quip2")]
        [Description("Equips Quip List 2.")]
        public static void Quip2_OnCommand(CommandEventArgs e)
        {
           // var msgSent = false;
            var parent = e.Mobile;
            Mobile m = (Mobile)parent;
            var pm = m as PlayerMobile;
            Container pack = m.Backpack;
            var count = pm.QuipList2.Count;
            Quip0_OnCommand(e); //quip0 called because else the character won't unequip already equipped items.
            if (count == 0)
            {
                m.SendMessage("Nothing in Quip List 2!");
            }
            else foreach (var i in pm.QuipList2)
            {
                    if (pm.Alive)
                    {
                        //if (msgSent == false && (!pack.Items.Contains(i)) || (!pack.Items.Contains(pm.QuipBag)))
                        //{
                        //    m.SendMessage("Some of your equipment is no longer in your pack!");
                        //    msgSent = true;
                        //}
                        if (i != null && (pack.Items.Contains(i) || pack.Items.Contains(pm.QuipBag)))
                            pm.EquipItem(i);

                    }
                    else m.SendMessage("You are dead and cannot equip anything!");
                }
        }

        [Usage("Quip1")]
        [Description("Equips Quip List 1.")]
        public static void Quip1_OnCommand(CommandEventArgs e)
        {
           // var check = false;
            var parent = e.Mobile;
            Mobile m = (Mobile)parent;
            var pm = m as PlayerMobile;
            Container pack = m.Backpack;
            var count = pm.QuipList.Count;
            Quip0_OnCommand(e); //quip0 called because else the character won't unequip already equipped items. 
            if (count == 0)
            {
                m.SendMessage("Nothing in Quip List 1!");
            }
            //if (check == false && (pack.Items.Contains(i) == false) || (!pack.Items.Contains(pm.QuipBag) == false))
            //{
            //    m.SendMessage("Some of your equipment is no longer in your pack!");
            //    check = true;
            //}
            else foreach (var i in pm.QuipList)
            {
                    if (pm.Alive)
                    { 

                        if (i != null && (pack.Items.Contains(i) || pack.Items.Contains(pm.QuipBag)))
                            pm.EquipItem(i);

                    }
                    else m.SendMessage("You are dead and cannot equip anything!");
            }

        }

        [Usage("Quip0")]
        [Description("Unequips Everything.")]
        public static void Quip0_OnCommand(CommandEventArgs e)
        {
            var parent = e.Mobile;
            Mobile m = (Mobile)parent;
            var pm = m as PlayerMobile;
            Container pack = m.Backpack;
            Container quipBag = pm.QuipBag;

            Item iTorso = m.FindItemOnLayer(Layer.InnerTorso);
            Item oTorso = m.FindItemOnLayer(Layer.OuterTorso);
            Item arms = m.FindItemOnLayer(Layer.Arms);
            Item gloves = m.FindItemOnLayer(Layer.Gloves);
            Item helm = m.FindItemOnLayer(Layer.Helm);
            Item iLegs = m.FindItemOnLayer(Layer.InnerLegs);
            Item neck = m.FindItemOnLayer(Layer.Neck);
            Item oneHanded = m.FindItemOnLayer(Layer.OneHanded);
            Item twoHanded = m.FindItemOnLayer(Layer.TwoHanded);
            Item oLegs = m.FindItemOnLayer(Layer.OuterLegs);
            Item bracelet = m.FindItemOnLayer(Layer.Bracelet);
            Item cloak = m.FindItemOnLayer(Layer.Cloak);
            Item earrings = m.FindItemOnLayer(Layer.Earrings);
            Item mTorso = m.FindItemOnLayer(Layer.MiddleTorso);
            Item pants = m.FindItemOnLayer(Layer.Pants);
            Item ring = m.FindItemOnLayer(Layer.Ring);
            Item shirt = m.FindItemOnLayer(Layer.Shirt);
            Item shoes = m.FindItemOnLayer(Layer.Shoes);
            Item waist = m.FindItemOnLayer(Layer.Waist);
            Item talisman = m.FindItemOnLayer(Layer.Talisman);

            //check quip bag is set if not drop to backpack
            if (pm.QuipBag != null && pack.Items.Contains(quipBag) && pm.Alive)
            {
                quipBag.DropItem(iTorso);
                quipBag.DropItem(oTorso);
                quipBag.DropItem(arms);
                quipBag.DropItem(gloves);
                quipBag.DropItem(helm);
                quipBag.DropItem(iLegs);
                quipBag.DropItem(neck);
                quipBag.DropItem(oneHanded);
                quipBag.DropItem(twoHanded);
                quipBag.DropItem(oLegs);
                quipBag.DropItem(bracelet);
                quipBag.DropItem(cloak);
                quipBag.DropItem(earrings);
                quipBag.DropItem(mTorso);
                quipBag.DropItem(pants);
                quipBag.DropItem(ring);
                quipBag.DropItem(shirt);
                quipBag.DropItem(shoes);
                quipBag.DropItem(waist);
                quipBag.DropItem(talisman);
            }
            else if (pm.Alive)
            {
                m.SendMessage("No Quip Bag Set! Unquipping to Backpack!");
                pack.DropItem(iTorso);
                pack.DropItem(oTorso);
                pack.DropItem(arms);
                pack.DropItem(gloves);
                pack.DropItem(helm);
                pack.DropItem(iLegs);
                pack.DropItem(neck);
                pack.DropItem(oneHanded);
                pack.DropItem(twoHanded);
                pack.DropItem(oLegs);
                pack.DropItem(bracelet);
                pack.DropItem(cloak);
                pack.DropItem(earrings);
                pack.DropItem(mTorso);
                pack.DropItem(pants);
                pack.DropItem(ring);
                pack.DropItem(shirt);
                pack.DropItem(shoes);
                pack.DropItem(waist);
                pack.DropItem(talisman);
            }
        }

    }
}
//public Item FindItemOnLayer(Layer layer)
//{
//    var eq = m_Items;
//    int count = eq.Count;

//    for (int i = 0; i < count; ++i)
//    {
//        Item item = eq[i];

//        if (!item.Deleted && item.Layer == layer)
//        {
//            return item;
//        }
//    }

//    return null;
//}
