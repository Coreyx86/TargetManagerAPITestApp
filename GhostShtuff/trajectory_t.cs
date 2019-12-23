using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GhostShtuff
{
    public class trajectory_t
    {
        private uint BASE = 0;

        public int trTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value); }
        }// 0x0

        public Definitions.trType_t trType
        {
            get { return (Definitions.trType_t)Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0x04); }
            set { Manager.Instance.PS3.Extension.WriteUInt32(BASE + 0x04, Convert.ToUInt32(value)); }
        } // 0x4

        public int trDuration
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x08); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x08, value); }
        } // 0x8

        public Vector3 trBase
        {
            get { return Helper.ReadVec3(BASE + 0x0C); }
            set { Helper.WriteVec3(BASE + 0x0C, value); }
        } // 0xC
        public Vector3 trDelta
        {
            get { return Helper.ReadVec3(BASE + 0x18); }
            set { Helper.WriteVec3(BASE + 0x18, value); }
        } // 0x18

        public trajectory_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
