using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class gclient_s
    {
        public playerState_s ps; // 0x0
        public clientSession_s sess; // 0x3190
        public int spectatorClient;// 0x341C
        public int mFlags; // 0x3420
        public byte[] padding = new byte[4]; // 0x3424
        public int lastCmdTime; // 0x3428
        public int buttons; // 0x342C
        public int oldButtons; // 0x3430
        public int latched_buttons; // 0x3434
        public int buttonsSinceLastFrame; // 0x3438
        public Vector3 oldOrigin; // 0x343C
        public float fGunPitch; // 0x3448
        public float fGunYaw; // 0x344C
        public byte[] padding2 = new byte[8]; // 0x3450
        public Vector3 damage_from; // 0x3458
        public int damage_fromWorld; // 0x3464
        public int accurateCount; // 0x3468
        public int accuracy_shots; // 0x346C
        public int accuracy_hits; // 0x3470
        public int inactivityTime; // 0x3474
        public int inactivityWarning; // 0x3478
        public int lastVoiceTime; // 0x347C
        public int switchTeamTime; // 0x3480
        public float currentAimSpreadScale; // 0x3484
        public float[] prevLinkedInvQuat = new float[4]; // 0x3488
        public bool link_rotationMovesEyePos; // 0x3498
        public bool link_doCollision; // 0x3499
        public bool link_useTagAnglesForViewAngles; // 0x349A
        public bool link_useBaseAnglesForViewClamp; // 0x349B
        public float linkAnglesFrac; // 0x349C
        public viewClampState link_viewClamp; // 0x34A0
    }
}
