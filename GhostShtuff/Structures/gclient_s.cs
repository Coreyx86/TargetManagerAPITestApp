using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace GhostShtuff
{
    public class gclient_s
    {
        private uint BASE = 0;
        private playerState_s _ps = null;

        public playerState_s ps
        {
            get { return _ps; }
            set { _ps = value; }
        }// 0x0

        private clientSession_s _sess = null;

        public clientSession_s sess
        {
            get { return _sess; }
            set { _sess = value; }
        } // 0x3190

        public int spectatorClient
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x341C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x341C, value); }
        }// 0x341C

        public int mFlags
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3420); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3420, value); }
        }// 0x3420

        public byte[] padding
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x3424, 4); }
        } // 0x3424

        public int lastCmdTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3428); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3428, value); }
        } // 0x3428

        public int buttons
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x342c); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x342C, value); }
        } // 0x342C

        public int oldButtons
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3430); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3430, value); }
        } // 0x3430

        public int latched_buttons
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3434); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3434, value); }
        }
        // 0x3434

        public int buttonsSinceLastFrame
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3438); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3438, value); }
        } // 0x3438

        public Vector3 oldOrigin
        {
            get { return Helper.ReadVec3(BASE + 0x343C); }
            set { Helper.WriteVec3(BASE + 0x343C, value); }
        } // 0x343C

        public float fGunPitch
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x3448); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x3448, value); }
        } // 0x3448

        public float fGunYaw
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x344C); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x344C, value); }
        }// 0x344C

        public byte[] padding2
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x3450, 8); }
        } // 0x3450

        public Vector3 damage_from
        {
            get { return Helper.ReadVec3(BASE + 0x3458); }
            set { Helper.WriteVec3(BASE + 0x3458, value); }
        } // 0x3458

        public int damage_fromWorld
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3464); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3464, value); }
        } // 0x3464

        public int accurateCount
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3468); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3468, value); }
        } // 0x3468

        public int accuracy_shots
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x346C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x346C, value); }
        } // 0x346C

        public int accuracy_hits
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3470); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3470, value); }
        } // 0x3470
        public int inactivityTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3474); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3474, value); }
        }// 0x3474
        public int inactivityWarning
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3478); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3478, value); }
        } // 0x3478
        public int lastVoiceTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x347C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x347C, value); }
        } // 0x347C
        public int switchTeamTime// 0x3480
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x3480); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x3480, value); }
        }
        public float currentAimSpreadScale
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x3484); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x3484, value); }
        }// 0x3484

        public float[] prevLinkedInvQuat
        {
            get { return Manager.Instance.PS3.Extension.ReadFloats(BASE + 0X3488, 4); }
            set { Manager.Instance.PS3.Extension.WriteFloats(BASE + 0x3488, value);}
        } // 0x3488

        public bool link_rotationMovesEyePos
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x3498); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x3498, value); }
        } // 0x3498

        public bool link_doCollision
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x3499); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x3499, value); }
        } // 0x3499
        public bool link_useTagAnglesForViewAngles
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x349A); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x349A, value); }
        } // 0x349A
        public bool link_useBaseAnglesForViewClamp
        {
            get { return Manager.Instance.PS3.Extension.ReadBool(BASE + 0x349b); }
            set { Manager.Instance.PS3.Extension.WriteBool(BASE + 0x349b, value); }
        }// 0x349B
        public float linkAnglesFrac
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x349C); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x349C, value); }
        } // 0x349C

        private viewClampState _line_viewClamp = null;
        public viewClampState link_viewClamp
        {
            get { return _line_viewClamp; }
            set { _line_viewClamp = value; }
        } // 0x34A0

        public gclient_s() { }

        public gclient_s(uint BASE)
        {
            this.BASE = BASE;
            this._ps = new playerState_s(BASE + 0x00);
            this._sess = new clientSession_s(BASE + 0x3190);
            this._line_viewClamp = new viewClampState(BASE + 0x34A0);
        }
    }
}
