using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GhostShtuff
{
    public class clientSession_s
    {
        private uint BASE = 0;

        public Definitions.sessionState_t sessionState
        {
            get { return (Definitions.sessionState_t)Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0x0); } //0x0 is the offset in this structure in which this data is positioned 0x3190 is the position of this structure in gclient
        }// 0x3190

        public int clientNum
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x4); }
        } // 0x3194

        public int score
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x8); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x8, value); }
        } // 0x3198

        public int deaths
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC, value); }
        } // 0x319C

        public int kills
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x10); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x10, value); }
        } // 0x31A0

        public int assists
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x14); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x14, value); }

        } // 0x31A4

        public short scriptPersId
        {
            get { return Manager.Instance.PS3.Extension.ReadInt16(BASE + 0x18); }
            set { Manager.Instance.PS3.Extension.WriteInt16(BASE + 0x18, value); }

        } // 0x31A8

        public short undefined
        {
            get { return Manager.Instance.PS3.Extension.ReadInt16(BASE + 0x1A); }
        } // 0x31AA

        public Definitions.clientConnected_t connect
        {
            get { return (Definitions.clientConnected_t)Manager.Instance.PS3.Extension.ReadUInt32(BASE + 0x1C); }
            set { Manager.Instance.PS3.Extension.WriteUInt32(BASE + 0x1C, Convert.ToUInt32(value)); }

        } // 0x31AC

        private usercmd_s _cmd = null;

        public usercmd_s cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        } // 0x3200

        private usercmd_s _oldCmd = null;

        public usercmd_s oldCmd
        {
            get { return _oldCmd; }
            set { _oldCmd = value; }
        } // 0x31D8

        public int isLocalClient
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x70); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x70, value); }
        }// 0x31F8

        public int predictItemPickup
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x74); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x74, value); }

        } // 0x31FC

        public string name
        {
            get { return Manager.Instance.PS3.Extension.ReadString(BASE + 0x78); }
            set
            {
                string tmp = value;

                if (tmp.Length > 32)
                {
                    tmp = tmp.Substring(0, 32);
                }

                Manager.Instance.PS3.Extension.WriteString(BASE + 0x78, tmp); 
            }
        } // 0x31DC

        public int maxHealth
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xAA); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xAA, value); }

        } // 0x3228

        public int enterTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xAE); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xAE, value); }

        }// 0x322C

        private playerTeamState_t _teamState = null; //0xB2

        public playerTeamState_t teamState
        {
            get { return _teamState; }
            set { _teamState = value; }
        }// 0x3230

        public int voteCount
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xB6); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xB6, value); }

        } // 0x3234

        public int teamVoteCount
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xBA); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xBA, value); }
        } // 0x3238

        public float moveSpeedScaleMultiplier
        {
            get { return Manager.Instance.PS3.Extension.ReadFloat(BASE + 0xBE); }
            set { Manager.Instance.PS3.Extension.WriteFloat(BASE + 0xBE, value); }
        } // 0x323C

        public int viewmodelIndex
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC2); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC2, value); }
        } // 0x3240

        public int noSpectate
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xC6); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xC6, value); }
        } // 0x3244

        public int teamInfo
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0xCA); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0xCA, value); }
        } // 0x3248

        private clientState_s _cs = null;

        public clientState_s cs 
        {
            get { return _cs; }
            set { _cs = value; }
        } // 0x324C

        public byte[] padding2
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x15A, 16); }
        }// 0x3250

        public int psOffsetTime
        {
            get { return Manager.Instance.PS3.Extension.ReadInt32(BASE + 0x170); }
            set { Manager.Instance.PS3.Extension.WriteInt32(BASE + 0x170, value); }
        } // 0x32E8

        public byte[] padding3
        {
            get { return Manager.Instance.PS3.Extension.ReadBytes(BASE + 0x174, 0x130); }
        }// 0x32EC

        public clientSession_s() { }

        public clientSession_s(uint BASE)
        {
            this.BASE = BASE;
            this._cmd = new usercmd_s(BASE + 0x20);
            this._oldCmd = new usercmd_s(BASE + 0x48);
            this._teamState = new playerTeamState_t(BASE + 0xB2);
            this._cs = new clientState_s(BASE + 0xCE);
        }
    }
}
