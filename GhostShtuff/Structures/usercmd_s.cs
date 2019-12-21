using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GhostShtuff
{
    public class usercmd_s
    {
        private uint BASE = 0;

        public int serverTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value); }
        } // 0x0
        public int buttons
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x04); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x04, value); }
        } // 0x4

        public Vector3 angles
        {
            get { return Helper.ReadVec3(BASE + 0x8); }
            set { Helper.WriteVec3(BASE + 0x8, value); }
        } // 0x8

        public byte forwardmove
        {
            get { return Manager.Instance.PS3.Extension.ReadByte(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteByte(BASE + 0x14, value); }
        } // 0x14
        public byte rightmove
        {
            get { return Manager.Instance.PS3.Extension.ReadByte(BASE + 0x15); }
            set { Manager.Instance.PS3.Extension.WriteByte(BASE + 0x15, value); }
        } // 0x15

        public byte[] undefined2
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x16, 2); }
        }// 0x16

        public float meleeChargeYaw
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x18); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x18, value); }
        } // 0x18
        public byte meleeChargeDist
        {
            get { return Manager.Instance.PS3.Extension.ReadByte(BASE + 0x1C); }
            set { Manager.Instance.PS3.Extension.WriteByte(BASE + 0x1C, value); }
        } // 0x1C

        public byte[] _padding
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x1D, 4); }
        } // 0x1D

        public byte[] selectedLoc
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x21, 2); }
        } // 0x21
        public byte selectedLocAngle
        {
            get { return Manager.Instance.PS3.Extension.ReadByte(BASE + 0x23); }
            set { Manager.Instance.PS3.Extension.WriteByte(BASE + 0x23, value); }
        } // 0x3
        public int unknown
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x24); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x24, value); }
        } // 0x24

        public usercmd_s()
        {

        }

        public usercmd_s(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
