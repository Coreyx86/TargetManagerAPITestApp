using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class mover_ent_t
    {
        private uint BASE = 0;

        public float decelTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x0, value); }
        }  // 0x0
        public float aDecelTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x4, value); }
        }  // 0x4
        public float speed
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x8, value); }
        }  // 0x8
        public float aSpeed
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0xc); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0xc, value); }
        }  // 0xC
        public float midTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x10, value); }
        }  // 0x10
        public float aMidTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x14, value); }
        }  // 0x14
        public Vector3 pos1
        {
            get { return Helper.ReadVec3(BASE + 0x18); }
            set { Helper.WriteVec3(BASE + 0x18, value); }
        }  // 0x18
        public Vector3 pos2
        {
            get { return Helper.ReadVec3(BASE + 0x24); }
            set { Helper.WriteVec3(BASE + 0x24, value); }
        }  // 0x24
        public Vector3 pos3
        {
            get { return Helper.ReadVec3(BASE + 0x30); }
            set { Helper.WriteVec3(BASE + 0x30, value); }
        }  // 0x30
        public Vector3 apos1
        {
            get { return Helper.ReadVec3(BASE + 0x3C); }
            set { Helper.WriteVec3(BASE + 0x3C, value); }
        }  // 0x3C
        public Vector3 apos2
        {
            get { return Helper.ReadVec3(BASE + 0x48); }
            set { Helper.WriteVec3(BASE + 0x48, value); }
        }  // 0x48
        public Vector3 apos3
        {
            get { return Helper.ReadVec3(BASE + 0x54); }
            set { Helper.WriteVec3(BASE + 0x54, value); }
        }  // 0x54


        public mover_ent_t() { }

        public mover_ent_t(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
