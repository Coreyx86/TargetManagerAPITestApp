using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class viewClampState
    {
        private uint BASE = 0;
        private viewClamp _min, _max = null;

        public viewClamp min
        {
            get { return _min; }
            set { _min = value; }
        } // 0x0

        public viewClamp max
        {
            get { return _max; }
            set { _max = value; }
        } // 0x18

        public float accelTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x30); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x30, value); }
        }// 0x30
        public float decelTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x34); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x34, value); }
        } // 0x34
        public float totalTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x38); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x38, value); }
        } // 0x38
        public float startTime
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0x3c); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0x3c, value); }
        } // 0x3C

        public viewClampState()
        {

        }

        public viewClampState(uint BASE)
        {
            this.BASE = BASE;
            this._min = new viewClamp(BASE + 0x00);
            this._max = new viewClamp(BASE + 0x18);
        }
    }
}
