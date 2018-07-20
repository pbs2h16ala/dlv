using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerMod.Data.Misc
{
    class Item
    {
        private string name;
        private float value;
        private Boolean isIllegal;

        public Item()
        {

        }

        public string Name { get => name; set => name = value; }
        public float Value { get => value; set => this.value = value; }
        public bool IsIllegal { get => isIllegal; set => isIllegal = value; }

        public void Setup()
        {

        }

        public void SetupEmptyItem()
        {
            this.Name = "empty";
            this.Value = 0.0f;
            this.IsIllegal = false;
        }
    }
}
