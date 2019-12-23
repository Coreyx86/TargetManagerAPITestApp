using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class trigger_ent_t
    {
        private uint BASE = 0;

        public int threshold
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        public int accumulate
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4
        public int timestamp
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8
        public int singleUserEntIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0xC
        public int damage
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value); }
        } // 0x10
        public bool requireLookAt
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x14, value); }
        } // 0x14

        public trigger_ent_t() { }

        public trigger_ent_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
