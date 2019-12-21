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
                int pm_flags; // 0xC
        int otherFlags; // 0x10
        int linkFlags; // 0x14
        int pm_time; // 0x18
        public Vector3 origin; // 0x1C
        public Vector3 velocity; // 0x28
        int grenadeTimerLeft; // 0x34
        int throwBackGrenadeOwner; // 0x38
        byte[] padding = new byte[0x18]; // 0x3C
        int gravity; // 0x54
        float leanf; // 0x58
        int speed; // 0x5C
        public Vector3 deltaAngles; // 0x60
        int groundEntityNum; // 0x6C
        public Vector3 vLadderVec; // 0x70
        int jumpTime; // 0x7C
        float jumpOriginZ; // 0x80
        byte[] padding2 = new byte[0x24]; // 0x84
        int corpseIndex; // 0xA8
        int movementDir; // 0xAC
        int eFlags; // 0xB0
        byte[] padding3 = new byte[0x50]; // 0xB4
        int clientNum; // 0x104
        int viewModelIndex; // 0x108
        public Vector3 viewAngles; // 0x10C
        byte[] padding4 = new byte[0x38];
        int health; // 0x150
        byte[] padding5 = new byte[0x4]; // 0x154
        int maxHealth; // 0x158
        byte[] padding6 = new byte[0x58]; // 0x15C
        int locationSelectionInfo; // 0x1B4
        byte[] padding7 = new byte[0x1C]; // 0x1B8
        float moveSpeedScaleMultiplier; // 0x1D4
        byte[] padding8 = new byte[0xDC]; // 0x1D8
        int weaponId; // 0x2B4
        byte[] padding9 = new byte[4]; // 0x2B8
        int weaponState; // 0x2BC
        float weaponPosFrac; // 0x2C0
        float aimSpreadScale; // 0x2C4
        byte[] padding10 = new byte[0x8C]; // 0x2C8
        int secondaryWeaponAmmoCount; // 0x354
        byte[] padding11 = new byte[0x14]; // 0x158
        int primaryWeaponAmmoCount; // 0x36C
        byte[] padding12 = new byte[0xB8]; // 0x370
        int perks; // 0x428
        int perkSlotCount; // 0x42C
        byte[] padding13 = new byte[0x5C]; // 0x430
        int shellshockIndex; // 0x48C
        int shellshockTime; // 0x490
        int shellshockDuration; // 0x494
        byte[] padding14 = new byte[0x3B0]; // 0x370
        hudData_s hud; // 0x848
        byte[] padding15 = new byte[0x98]; // 0x318C


        public playerState_s() { }

        public playerState_s(uint BASE)
        {
            this.BASE = BASE;
        }
    }
}
