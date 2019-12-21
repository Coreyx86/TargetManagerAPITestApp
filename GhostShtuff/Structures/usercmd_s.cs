using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class usercmd_s
    {
        int serverTime; // 0x0
        int buttons; // 0x4
        int[] angles = new int[3]; // 0x8
        byte forwardmove; // 0x14
        byte rightmove; // 0x15
        byte[] undefined2 = new byte[2]; // 0x16
        float meleeChargeYaw; // 0x18
        byte meleeChargeDist; // 0x1C
        byte[] _padding = new byte[4]; // 0x1D
        byte[] selectedLoc = new byte[2]; // 0x21
        byte selectedLocAngle; // 0x3
        int unknown; // 0x24
    }
}
