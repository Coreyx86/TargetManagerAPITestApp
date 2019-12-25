using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class entityState_s_index
    {
        private uint BASE = 0;

        public int brushmodel
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        }
        public int item
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        }
        public int xmodel
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        }
        public int primaryLight
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        }

        public entityState_s_index(uint BASE)
        {
            this.BASE = BASE;
        }
    }
    
    public class entityState_s_un1
    {
        uint BASE = 0;

        public int scale
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        }
        public int eventParm2
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        }
        public int helicopterStage
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        }

        public entityState_s_un1(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class entityState_s_un2
    {
        uint BASE = 0;

        public int hintString
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        }
        public int grenadeInPickupRange
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        }
        public int vehicleXModel
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        }

        public entityState_s_un2(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class entityState_s
    {
        uint BASE = 0;

        public int number
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0

        public int eType
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4

        public int time2
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8

        public LerpEntityState lerp { get; set; } // 0xC

        public int otherEntityNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x7C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0x7C

        public int attackerEntityNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x80); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x80, value); }
        } // 0x80

        public int groundEntityNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x84); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x84, value); }
        } // 0x84


        public entityState_s_index index { get; set; } // 0x88

    public int loopSound
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8c); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8c, value); }
        } // 0x8C

    public int surfType
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x90); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x90, value); }
        } // 0x90

    public int clientNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x94); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x94, value); }
        } // 0x94

    public int headIconTeam
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x98); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x98, value); }
        } // 0x98

    public int headIcon
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x9c); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x9c, value); }
        } // 0x9C

    public uint eventParm
        {
            get { return Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0xA0); }
            set { Manager.Instance.PS3.Extension.WriteUInt32(BASE + 0xA0, value); }
        } // 0xA0

    public int solid
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xA4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xA4, value); }
        } // 0xA4

    public int eventSequence
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xA8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xA8, value); }
        } // 0xA8

    public int[] events
        {
            get
            {
                int[] tmp = new int[4];

                for(uint i = 0; i < 4;i++)
                {
                    tmp[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xAC + (i * 4));
                }

                return tmp;
            }
            set
            {
                uint i = 0;
                foreach(int v in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xAC + i, v);
                    i+=4;
                }
            }
        }  // 0xAC


    public int[] eventParms
        {
            get
            {
                int[] tmp = new int[4];

                for(uint i = 0; i < 4; i++)
                {
                    tmp[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xBC + (i * 4));
                }

                return tmp;
            }
            set
            {
                uint i = 0;
                foreach(int v in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xBC + i, v);
                    i += 4;
                }
            }
        }// 0xBC

    public int weapon
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xCC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xCC, value); }
        } // 0xCC

        public int legsAnim
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xD0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xD0, value); }
        } // 0xD0

        public int torsoAnim
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xD4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xD4, value); }
        }// 0xD4

        public entityState_s_un1 un1 { get; set; } // 0xD8 i think this is a pointer
        public entityState_s_un2 un2 { get; set; }

        public int clientLinkInfo
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xE0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xE0, value); }
        } // 0xE0

        public int[] partBits
        {
            get
            {
                int[] tmp = new int[6];

                for (uint i = 0; i < 4; i++)
                {
                    tmp[i] = Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xe4 + (i * 4));
                }
                return tmp;
            }
            set
            {
                uint i = 0;
                foreach (int v in value)
                {
                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xE4 + i, v);
                    i += 4;
                }
            }
        }
            // 0xE4


        public entityState_s(uint BASE)
        {
            this.BASE = BASE;

            this.index = new entityState_s_index(Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0x88));
            this.un1 = new entityState_s_un1(Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0xD8));
            this.un2 = new entityState_s_un2(Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0xDC));
        }
    }
}
