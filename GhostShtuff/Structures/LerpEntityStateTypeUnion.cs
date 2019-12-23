using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GhostShtuff
{
    public class LerpEntityStateTurret
    {
        private uint BASE = 0;

        public Vector3 gunAngles
        {
            get { return Helper.ReadVec3(BASE + 0x0); }
            set { Helper.WriteVec3(BASE + 0x0, value); }
        }// 0x0

        public int lastBarrelRotChangeTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value);
            }
        }// 0x4
        public int lastBarrelRotChangeRate
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value);
            }
        } // 0x8
        public int lastHeatChangeTime
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value);
            }
        } // 0xC
        public int lastHeatChangeLevel
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10);
            }
            set
            {
                Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value);
            }
        } // 0x10

        public LerpEntityStateTurret(uint BASE)
        {
            this.BASE = BASE;
        }
    }
    public class LerpEntityStateLoopFx
    {
        private uint BASE = 0;

        public int cullDist
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        }// 0x0
        public int period
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4

        public LerpEntityStateLoopFx(uint BASE)
        {
            this.BASE = BASE;
        }
    }
    public class LerpEntityStatePlayer
    {
        private uint BASE = 0;

        public int leanf
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        public int movementDir
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4
        public int torsoPitch
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8
        public int waistPitch
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xc); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xc, value); }
        } // 0xC
        public int offhandWeapon
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value); }
        } // 0x10
        public int lastSpawnTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x14, value); }
        } // 0x14

        public LerpEntityStatePlayer(uint BASE)
        {
            this.BASE = BASE;
        }
    }
    public class LerpEntityStateScriptMover
    {
        uint BASE = 0;

        public int entToTakeMarksFrom
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        int xModelIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4
        int animIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8
        int animTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xc); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xc, value); }
        } // 0xC

        public LerpEntityStateScriptMover(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStateVehicle
    {
        uint BASE = 0;

        public int indices
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0

        public int flags
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4

        public int bodyPitch
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8

        public int bodyRoll
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0xC

        public int steerYaw
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value); }
        } // 0x10

        public int gunPitch
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x14, value); }
        } // 0x14
        public int gunYaw
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x18); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x18, value); }
        } // 0x18
        public int playerIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x1C); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x1C, value); }
        } // 0x1C
        public int pad
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x20); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x20, value); }
        } // 0x20

        public LerpEntityStateVehicle(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStatePlane
    {
        uint BASE = 0;

        public int ownerNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        public int enemyIcon
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4
        public int friendIcon
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x8

        public LerpEntityStatePlane(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStateMissile
    {
        uint BASE = 0;

        public int launchTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        } // 0x0
        public int flightMode
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x4, value); }
        } // 0x4

        public LerpEntityStateMissile(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStateSoundBlend
    {
        uint BASE = 0;

        public int lerp
        {
            get
            {
                return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x0);
            }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x0, value); }
        }

        public LerpEntityStateSoundBlend(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStateAnonymous
    {
        uint BASE = 0;

        public int[] data
        {
            get
            {
                List<int> tmp = new List<int>();

                for(uint i = 0; i < 6; i++)
                {
                    tmp.Add(Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x00 + (i * 0x4)));
                }

                return tmp.ToArray();
            }
            set
            {
                uint i = 0;
                foreach(int v in value)
                {
                    if(i == 6)
                    {
                        break;
                    }

                    Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x00 + (i * 0x4));
                    i++;
                }
            }
        }

        public LerpEntityStateAnonymous(uint BASE)
        {
            this.BASE = BASE;
        }
    }

    public class LerpEntityStateTypeUnion
    {
        private uint BASE = 0;

        public LerpEntityStateTurret turret;
        public LerpEntityStateLoopFx loopFx;
        public LerpEntityStatePlayer player;
        public LerpEntityStateScriptMover scriptMover;
        public LerpEntityStateVehicle vehicle;
        public LerpEntityStatePlane plane;
        public LerpEntityStateMissile missile;
        public LerpEntityStateSoundBlend soundBlend;
        public LerpEntityStateAnonymous anonymous;

        public LerpEntityStateTypeUnion(uint BASE)
        {
            this.BASE = BASE;

            this.turret = new LerpEntityStateTurret(BASE + 0x0);
            this.loopFx = new LerpEntityStateLoopFx(BASE + 0x14);
            this.player = new LerpEntityStatePlayer(BASE + 0x1C);
            this.scriptMover = new LerpEntityStateScriptMover(BASE + 0x34);
            this.vehicle = new LerpEntityStateVehicle(BASE + 0x44);
            this.plane = new LerpEntityStatePlane(BASE + 0x68);
            this.missile = new LerpEntityStateMissile(BASE + 0x74);
            this.soundBlend = new LerpEntityStateSoundBlend(BASE + 0x7C);
            this.anonymous = new LerpEntityStateAnonymous(BASE + 0x80);
        }
    }
}
