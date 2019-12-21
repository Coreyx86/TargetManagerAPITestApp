using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class clientSession_s
    {
        Definitions.sessionState_t sessionState; // 0x3190
        int clientNum; // 0x3194
        int score; // 0x3198
        int deaths; // 0x319C
        int kills; // 0x31A0
        int assists; // 0x31A4
        short scriptPersId; // 0x31A8
        short undefined; // 0x31AA
        Definitions.clientConnected_t connect; // 0x31AC
        usercmd_s cmd; // 0x3200
        usercmd_s oldCmd; // 0x31D8
        int isLocalClient; // 0x31F8
        int predictItemPickup; // 0x31FC
        byte[] name = new byte[32]; // 0x31DC
        int maxHealth; // 0x3228
        int enterTime; // 0x322C
        playerTeamState_t teamState; // 0x3230
        int voteCount; // 0x3234
        int teamVoteCount; // 0x3238
        float moveSpeedScaleMultiplier; // 0x323C
        int viewmodelIndex; // 0x3240
        int noSpectate; // 0x3244
        int teamInfo; // 0x3248
        clientState_s cs; // 0x324C
        byte[] padding2 = new byte[16]; // 0x3250
        int psOffsetTime; // 0x32E8
        byte[] padding3 = new byte[0x130]; // 0x32EC
    }
}
