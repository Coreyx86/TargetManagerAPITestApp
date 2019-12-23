using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class entityState_s_index
    {
        int brushmodel;
        int item;
        int xmodel;
        int primaryLight;
    }
    
    public class entityState_s_un1
    {
        int scale;
        int eventParm2;
        int helicopterStage;
    }

    public class entityState_s_un2
    {
        int hintString;
        int grenadeInPickupRange;
        int vehicleXModel;
    }

    public class entityState_s
    {
        int number; // 0x0
        int eType; // 0x4
        int time2; // 0x8
        LerpEntityState lerp; // 0xC
        int otherEntityNum; // 0x7C
        int attackerEntityNum; // 0x80
        int groundEntityNum; // 0x84
        entityState_s_index index; // 0x88
int loopSound; // 0x8C
    int surfType; // 0x90
    int clientNum; // 0x94
    int headIconTeam; // 0x98
    int headIcon; // 0x9C
    uint eventParm; // 0xA0
    int solid; // 0xA4
    int eventSequence; // 0xA8
    int[] events = new int[4]; // 0xAC
    int[] eventParms = new int[4]; // 0xBC
    int weapon; // 0xCC
    int legsAnim; // 0xD0
    int torsoAnim; // 0xD4
    entityState_s_un1 un1; // 0xD8 i think this is a pointer
        entityState_s_un2 un2;
int clientLinkInfo; // 0xE0
int[] partBits = new int[6]; // 0xE4
    }
}
