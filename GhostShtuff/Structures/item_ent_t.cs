using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class item_ent_t
    {
        private uint BASE = 0;

        public int ammoCount
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value); }
        }// 0x0

        public int[] clipAmmoCount
        {
            get
            {
                return new int[]
                {
                    Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4),
                    Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8)
                };
            }
            set
            {
                int pos = 0;
                foreach (int i in value)
                {
                    //To ensure we don't accidentally overwrite
                    if (i == 8)
                    {
                        break;
                    }

                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, i);
                    pos += 4;
                }
            }
        } // 0x4

        public int weaponIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0xC
        public bool dualWieldItem
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x10, value); }
        } // 0x10

        public item_ent_t() { }

        public item_ent_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
