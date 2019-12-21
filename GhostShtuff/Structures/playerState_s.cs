using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GhostShtuff
{
    public class playerState_s
    {
        private uint BASE = 0;

        public int commandTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00, value);
            }
        } //0x00

        public int pm_type
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x04);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x04, value);
            }
        } // 0x4

        public int bobCycle
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value);

            }
        }// 0x8
        public int pm_flags
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value);
            }
        }// 0xC

        public int otherFlags
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value);
            }
        }// 0x10

        public int linkFlags
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x14);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x14, value);
            }
        }// 0x14

        public int pm_time
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x18); }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x18, value);
            }
        }// 0x18

        public Vector3 origin
        {
            get
            {
                return Helper.ReadVec3(BASE + 0x1C);
            }
            set
            {
                Helper.WriteVec3(BASE + 0x1C, value);
            }
        }// 0x1C
        public Vector3 velocity {
            get {
                return Helper.ReadVec3(BASE + 0X28);
            }
            set {
                Helper.WriteVec3(BASE + 0x28, value); } } // 0x28

        public int grenadeTimerLeft
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x34);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x34, value);
            }
        }// 0x34q

        public int throwBackGrenadeOwner
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x38);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0X38, value);
            }
        }// 0x38

        public byte[] padding
        {
            get
            {
                return Manager.Instance.PS3.GetBytes(BASE + 0X3C, 0x18);
            }
        }// 0x3C

        public int gravity
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x54);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x54, value);
            }
        }// 0x54

        public float leanf
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x58);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x58, value);
            }
        }// 0x58

        public int speed
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x5c); }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x5c, value);
            }
        }// 0x5C

        public Vector3 deltaAngles
        {
            get
            {
                return Helper.ReadVec3(BASE + 0x60);
            }
            set { Helper.WriteVec3(BASE + 0x60, value); }
        }// 0x60

        public int groundEntityNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x6c); }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x6C, value);
            }
        }// 0x6C

        public Vector3 vLadderVec
        {
            get
            {
                return Helper.ReadVec3(BASE + 0x70);
            }
            set
            {
                Helper.WriteVec3(BASE + 0x70, value);
            }
        }// 0x70

        public int jumpTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x7c);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x7c, value);
            }
        }// 0x7C

        public float jumpOriginZ
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x80);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x80, value);
            }
        }// 0x80

        public byte[] padding2
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x84, 0x24);
            }
        }// 0x84

        public int corpseIndex
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xA8);
            }
        }// 0xA8
        public int movementDir
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xAC);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xAC, value);

            }
        }// 0xAC

        public int eFlags
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xB0);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xb0, value);
            }
        }
                // 0xB0
        public byte[] padding3
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0xB4, 0x50);
            }
        }// 0xB4

        public int clientNum
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x104);
            }
        }// 0x104

        public int viewModelIndex
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x108);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x108, value);
            }
        }// 0x108

        public Vector3 viewAngles
        {
            get
            {
                return Helper.ReadVec3(BASE + 0x10c);
            }
            set
            {
                Helper.WriteVec3(BASE + 0x10c, value);
            }
        }// 0x10C

        public byte[] padding4
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x150, 0x38);
            }
        }

        public int health
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x150);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x150, value);
            }
        }// 0x150

        public byte[] padding5
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x154, 4);
            }
        } // 0x154

        public int maxHealth
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x158);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x158, value);
            }
        }// 0x158

        public byte[] padding6
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x15c, 0x58 );
            }
        }

        public int locationSelectionInfo
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x1b4);
            }
        }// 0x1B4

        public byte[] padding7
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x1b8, 0x1c);
            }
        } // 0x1B8

        public float moveSpeedScaleMultiplier
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x1d4);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x1d4, value);
            }
        }// 0x1D4

        public byte[] padding8
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x1d8, 0xDC);
            }
        }// 0x1D8

        public int weaponId
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x2b4);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x2b4, value);
            }
        }// 0x2B4

        public byte[] padding9
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x2b8, 4);
            }
        } // 0x2B8

        public int weaponState
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x2bC);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x2bC, value);

            }
        }// 0x2BC

        public float weaponPosFrac
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x2C0);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x2C0, value);
            }
        }// 0x2C0

        public float aimSpreadScale
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x2c4);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x2c4, value);
            }
        }// 0x2C4

        public byte[] padding10
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x2C8, 0x8c);
            }
        }  // 0x2C8

        public int secondaryWeaponAmmoCount
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x354);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x354, value);
            }
        }// 0x354

        public byte[] padding11
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x2bC,0x14);
            }
        } // 0x158

        public int primaryWeaponAmmoCount
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x36c);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x36c, value);
            }
        }// 0x36C

        public byte[] padding12
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x370,0xb8 );
            }
        }// 0x370
        public int perks
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x428);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x428, value);
            }
        }// 0x428

        public int perkSlotCount
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x42c);
            }
            set
            {
                 Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x42c);
            }
        }// 0x42C

        public byte[] padding13
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x430, 0x5C);
            }
        } // 0x430

        public int shellshockIndex
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x48c);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x48c, value);
            }
        }// 0x48C

        public int shellshockTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x490);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x490, value);

            }
        }// 0x490

        public int shellshockDuration
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x494);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x494, value);
            }
        }// 0x494

        public byte[] padding14
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x498,0x3b0 );
            }
        }  // 0x370

        //public hudData_s
        public byte[] hud
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x848, 0x2944); }
        } // 0x848

        public byte[] padding15
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x318C, 0x98);
            }
        }  // 0x318C


        public playerState_s() { }

        public playerState_s(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
