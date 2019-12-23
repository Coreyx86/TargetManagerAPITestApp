using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class corpse_ent_t
    {
        private uint BASE = 0;
        public int deathAnimStartTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value);}
        } // 0x0\

        public corpse_ent_t() { }

        public corpse_ent_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
