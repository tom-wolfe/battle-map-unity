using UnityEngine;

namespace Assets.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Invert(this Vector3 vector)
        {
            return vector * -1f;
        }
    }
}
