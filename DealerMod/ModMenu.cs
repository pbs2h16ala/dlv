using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
using GTA.Math;
using NativeUI;

namespace DealerMod
{
    class ModMenu
    {
        MenuPool menuPool;
        UIMenu modMenu_main;
        UIMenu modMenu_dealer;


        public ModMenu()
        {
            this.InitModMenu();
        }

        private void InitModMenu()
        {
            this.menuPool = new MenuPool();

            this.modMenu_main = new UIMenu("CopsV", "complete Overhaul");
            this.menuPool.Add(modMenu_main);
            this.modMenu_main.RefreshIndex();

            this.InitSubMenuDealer();
            menuPool.RefreshIndex();
        }

        private void InitSubMenuDealer()
        {
            // Init submenu
            this.modMenu_dealer = menuPool.AddSubMenu(modMenu_main, "Dealer");

            // Init Item 1
            this.modMenu_dealer.AddItem(new UIMenuItem("Rank: " + Dealer.dealer.GetDealerRank()));

            // Init Item 2
            this.modMenu_dealer.AddItem(new UIMenuItem("Reputation: " + Dealer.dealer.GetCustomerReputation()));

            // Init Item 3
            List<dynamic> backpack = Dealer.dealer.Backpack.Items; // change to string-displayName
            this.modMenu_dealer.AddItem(new UIMenuListItem("Backpack:", backpack, Dealer.dealer.Backpack.Items.Count));

            // Init Item 4 
            this.modMenu_dealer.AddItem(new UIMenuItem("Stats")); // change to submenu

            // modMenu_dealer.OnItemSelect += ItemSelectHandler; // Overwrite

            this.modMenu_dealer.RefreshIndex();
        }

        public void ItemSelectHandler(UIMenu sender, UIMenuItem selectedItem, int index)
        {
            UI.Notify("You have selected: ~b~" + selectedItem.Text);

            UI.ShowSubtitle("Index: " + index);
        }


        public void OnTick()
        {
            this.ProcessMenusIfNeeded();

        }

        private void ProcessMenusIfNeeded()
        {
            if (this.modMenu_main.Visible)
            {
                this.menuPool.ProcessMenus();
            }
        }

        public void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                abFlash.PerformAbilityAction();
            }

            if (e.KeyCode == Keys.K)
            {
                this.ToggleMainMenu();
            }
        }

        public void ToggleMainMenu()
        {
            this.modMenu_main.Visible = !this.modMenu_main.Visible;
        }
    }
}
