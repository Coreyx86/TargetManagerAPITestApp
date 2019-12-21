using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class viewClampState
    {
        viewClamp min; // 0x0
        viewClamp max; // 0x18
        float accelTime; // 0x30
        float decelTime; // 0x34
        float totalTime; // 0x38
        float startTime; // 0x3C
    }
}
