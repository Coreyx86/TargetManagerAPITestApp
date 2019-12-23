using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GhostShtuff.Structures
{
    public class LerpEntityStateTurret
    {
        private uint BASE = 0;

        public Vector3 gunAngles
        {
            get { return Helper.ReadVec3(BASE + 0x0); }
            set { Helper.WriteVec3(BASE + 0x0, value); }
        }// 0x0

        public int lastBarrelRotChangeTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value);
            }
        }// 0x4
        public int lastBarrelRotChangeRate
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value);
            }
        } // 0x8
        public int lastHeatChangeTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value);
            }
        } // 0xC
        public int lastHeatChangeLevel
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value);
            }
        } // 0x10

        public LerpEntityStateTurret(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
