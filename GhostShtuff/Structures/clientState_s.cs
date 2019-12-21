using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class clientState_s
    {
        int clientNum; // 0x0
        int team; // 0x4
        int modelIndex; // 0x8
        int dualWielding; // 0xC
        int riotShieldNext; // 0x10
        int[] attachModelIndex = new int[6]; // 0x14
        int[] attachTagIndex = new int[6]; // 0x2C
        byte[] name = new byte[32]; // 0x44
        float maxSprintTimeMultiplier; // 0x64
        int rank; // 0x68
        int prestige; // 0x6C
        int[] perks = new int[2]; // 0x70
        int voiceConnectivityBits; // 0x78
        int clanIndex; // 0x7C
        byte[] clanName = new byte[4]; // 0x80
        int attachedVehEntNum; // 0x84
        int attachedVehSlotIndex; // 0x88
    }
}
