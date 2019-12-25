using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class gentity_union
    {
        item_ent_t item;
        trigger_ent_t trigger;
        mover_ent_t mover;
        corpse_ent_t corpse;
    }   

    public class gentity_s
    {
        //entityState_s s; // 0x0
        //enitityShared_t r; // 0xFC
        public gclient_s client { get; set; } // 0x158 //pointer to gclient
        //turretInfo_s* pTurretInfo; // 0x15C
        //scr_vehicle_s* scr_vehicle; // 0x160
        //dxBody* physicsBody; // 0x164
        short model; // 0x168
        byte physicsObject; // 0x16A
        byte takedamage; // 0x16B
        byte active; // 0x16C
        byte handler; // 0x16D
        byte team; // 0x16E
        byte freeAfterEvent; //0x16F
        UInt16 code_classname; // 0x172
        UInt16 classname; // 0x174
        UInt16 script_linkname; // 0x176
        UInt16 target; // 0x178
        UInt16 targetname; // 0x17A
        int attachIgnoreCollision; // 0x17C
        int spawnFlags; // 0x180
        int flags; // 0x184
        int unlinkAfterEvent; // 0x188
        int clipMask; // 0x18C
        int processedFrame; // 0x190
        //EntHandle parent; // 0x194
        int nextthink; // 0x198
        int health; // 0x19C
        int maxhealth; // 0x1A0
        int damage; // 0x1A4
        int count; // 0x1A8

        gentity_union union;
        //EntHandle projEntity; // 0x20C
        //EntHandle linkedEntity; // 0x210
        int tagInfo; // 0x214
                    
        //gentity_s* tagChildren; // 0x218 pointer
        UInt16[] attachModelNames = new UInt16[19]; // 0x21C
        UInt16[] attachTagNames = new UInt16[19]; // 0x242
        int useCount; // 0x268
        int nextFree; // 0x26C
        int birthtime; // 0x270
        byte[] unknown = new byte[0xC]; // 0x274
    }
}