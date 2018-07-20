using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerMod.Data.Misc
{
    class Backpack
    {
        private int size;
        private List<dynamic> items;

        public int Size { get => size; set => size = value; }
        internal List<dynamic> Items { get => items; set => items = value; }

        public Backpack()
        {

        }

        public void Setup()
        {
            this.Size = 25;
            this.Items = new List<dynamic>();
        }

        public void Setup(int size)
        {
            this.Size = size;
            this.Items = new List<dynamic>();
        }

        public List<int> GetFreeItemSlots()
        {
            List<int> freeItemSlots = new List<int>();

            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.IsItemSlotEmpty(i))
                {
                    freeItemSlots.Add(i);
                }
            }

            return freeItemSlots;
        }

        public bool IsItemSlotEmpty(int index)
        {
            if (this.Items[index].Name == "empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
