using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class Definitions
    {
        /* gentity_s->flags */
        public uint FL_GODMODE = 0x1;
        public uint FL_DEMI_GODMODE = 0x2;
        public uint FL_NO_KNOCKBACK = 0x8;
        public uint FL_CAN_RADIUS_DAMAGE = 0x10;
        public uint FL_SUPPORTS_LINKTO = 0x1000;
        public uint FL_GRENADE_TOUCH_DAMAGE = 0x4000;
        public uint FL_STABLE_MISSILES = 0x20000;

        public enum sessionState_t
        {
            SESS_STATE_PLAYING,
            SESS_STATE_DEAD,
            SESS_STATE_SPECTATOR,
            SESS_STATE_INTERMISSION
        };

        public enum clientConnected_t
        {
            CON_DISCONNECTED,
            CON_CONNECTING,
            CON_CONNECTED
        };

        public enum entityType_t
        {
            ET_GENERAL = 0x0,
            ET_PLAYER = 0x1,
            ET_PLAYER_CORPSE = 0x2,
            ET_ITEM = 0x3,
            ET_MISSILE = 0x4,
            ET_INVISIBLE = 0x5,
            ET_SCRIPTMOVER = 0x6,
            ET_SOUND_BLEND = 0x7,
            ET_FX = 0x8,
            ET_LOOP_FX = 0x9,
            ET_PRIMARY_LIGHT = 0xA,
            ET_TURRET = 0xB,
            ET_HELICOPTER = 0xC,
            ET_PLANE = 0xD,
            ET_VEHICLE = 0xE,
            ET_VEHICLE_COLLMAP = 0xF,
            ET_VEHICLE_CORPSE = 0x10,
            ET_VEHICLE_SPAWNER = 0x11
        };
    }
}
