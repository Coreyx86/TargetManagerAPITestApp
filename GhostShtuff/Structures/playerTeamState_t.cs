using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class playerTeamState_t
    {
        private uint BASE = 0;

        public int location
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value); }
        } // 0x0

        public playerTeamState_t() { }

        public playerTeamState_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
