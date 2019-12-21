using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using PS3Lib;

namespace GhostShtuff
{
    public static class Helper
    {
        public static Vector2 ReadVec2(uint address)
        {
            float[] vec2 = Manager.Instance.PS3.Extension.ReadFloats(address, 2);

            return new Vector2(vec2[0], vec2[1]);
        }

        public static Vector3 ReadVec3(uint address)
        {
            float[] vec3 = Manager.Instance.PS3.Extension.ReadFloats(address, 3);

            return new Vector3(vec3[0], vec3[1], vec3[2]);
        }

        public static Vector4 ReadVec4(uint address)
        {
            float[] vec4 = Manager.Instance.PS3.Extension.ReadFloats(address, 4);

            return new Vector4(vec4[0], vec4[1], vec4[2], vec4[3]);
        }

        public static void WriteVec2(uint address, Vector2 value)
        {
            Manager.Instance.PS3.Extension.WriteFloats(address, new float[] { value.X, value.Y });
        }

        public static void WriteVec3(uint address, Vector3 value)
        {
            Manager.Instance.PS3.Extension.WriteFloats(address, new float[] { value.X, value.Y, value.Z });

        }

        public static void WriteVec4(uint address, Vector4 value)
        {
            Manager.Instance.PS3.Extension.WriteFloats(address, new float[] {value.W, value.X, value.Y, value.Z });

        }
    }
}
