using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class clientState_s
    {
        private uint BASE = 0;

        public int clientNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        public int team
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4
        public int modelIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8
        public int dualWielding
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0xC
        public int riotShieldNext
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value); }
        } // 0x10

        public int[] attachModelIndex
        {
            get
            {
                int[] buffer = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    buffer[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x14);
                }

                return buffer;
            }
            set
            {
                uint pos = 0;
                foreach (int i in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x14 + pos, i);
                    pos += 0x4;
                }
            }
        } // 0x14

        public int[] attachTagIndex
        {
            get
            {
                int[] buffer = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    buffer[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x2C);
                }

                return buffer;
            }
            set
            {
                uint pos = 0;
                foreach (int i in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x2C + pos, i);
                    pos += 0x4;
                }
            }
        } // 0x2C

        public string name
        {
            get { return Manager.Instance.PS3.Extension.ReadString(BASE + 0x44); }
            set
            {
                string tmp = value;
                if (tmp.Length > 32)
                {
                    tmp = tmp.Substring(0, 32);
                }
                Manager.Instance.PS3.Extension.WriteString(BASE + 0x44, tmp);
            }
        } // 0x44

        public float maxSprintTimeMultiplier
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x64); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x64, value); }
        } // 0x64
        public int rank
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x68); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x68, value); }
        } // 0x68
        public int prestige
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x6C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x6C, value); }
        } // 0x6C
        public int[] perks
        {
            get
            {
                int[] buffer = new int[2];

                for (int i = 0; i < 2; i++)
                {
                    buffer[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x70);
                }

                return buffer;
            }
            set
            {
                uint pos = 0;
                foreach (int i in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x70 + pos, i);
                    pos += 0x4;
                }
            }
        }  // 0x70

        public int voiceConnectivityBits
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x78); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x78, value); }
        } // 0x78
        public int clanIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x7C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x7C, value); }
        }// 0x7C

        public string clanName
        {
            get { return Manager.Instance.PS3.Extension.ReadString(BASE + 0x80); }
            set
            {
                string tmp = value;
                if (tmp.Length > 32)
                {
                    tmp = tmp.Substring(0, 32);
                }

                Manager.Instance.PS3.Extension.WriteString(BASE +0x80, tmp);
            }
        }  // 0x80
        public int attachedVehEntNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x84); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x84, value); }
        } // 0x84
        public int attachedVehSlotIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x88); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x88, value); }
        }// 0x88

        public clientState_s() { }
        public clientState_s(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
