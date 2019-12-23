using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class LerpEntityState
    {
        private uint BASE = 0;

        public int eFlags
        {
            get { return Manager.Instance.PS3.ReadInt32(BASE + 0x0C); }
            set { Manager.Instance.PS3.WriteInt32(BASE + 0x0C, value); }
        } // 0x0

        public trajectory_t pos { get; set; } // 0x4
        public trajectory_t apos { get; set; } // 0x24

        public LerpEntityStateTypeUnion u; // 0x34

        public LerpEntityState(uint BASE)
        {
            this.BASE = BASE;

            this.pos = new trajectory_t(BASE + 0x4);
            this.apos = new trajectory_t(BASE + 0x24);
            this.u = new LerpEntityStateTypeUnion(BASE + 0x34);
        }
    }
}
