using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GhostShtuff
{
    public class viewClamp
    {
        private uint BASE = 0;

        public Vector2 start
        {
            get { return Helper.ReadVec2(BASE + 0x0); }
            set { Helper.WriteVec2(BASE + 0x0, value); }
        } // 0x0
        public Vector2 current
        {
            get { return Helper.ReadVec2(BASE + 0x8); }
            set { Helper.WriteVec2(BASE + 0x8, value); }
        }  // 0x8
        public Vector2 goal
        {
            get { return Helper.ReadVec2(BASE + 0x10); }
            set { Helper.WriteVec2(BASE + 0x10, value); }
        }  // 0x10

        public viewClamp() { }

        public viewClamp(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
