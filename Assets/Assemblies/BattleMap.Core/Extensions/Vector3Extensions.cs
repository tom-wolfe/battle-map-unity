using UnityEngine;

namespace BattleMap.Core.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Clamp(this Vector3 vector, Bounds bounds)
        {
            var result = new Vector3(
                x: Mathf.Clamp(vector.x, bounds.min.x, bounds.max.x),
                y: Mathf.Clamp(vector.y, bounds.min.y, bounds.max.y),
                z: Mathf.Clamp(vector.z, bounds.min.z, bounds.max.z)
            );
            return result;
        }
    }
}
