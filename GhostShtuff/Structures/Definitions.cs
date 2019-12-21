using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class Definitions
    {
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
    }
}
