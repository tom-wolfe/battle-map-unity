using UnityEngine;

namespace BattleMap.Core.Extensions
{
    public static class BoundsExtensions
    {
        public static Bounds Inflate(this Bounds bounds, Vector3 size)
        {
            var result = new Bounds(
                center: bounds.center,
                size: bounds.size + size
            );
            return result;
        }

        public static Bounds Deflate(this Bounds bounds, Vector3 size)
        {
            var result = new Bounds(
                center: bounds.center,
                size: bounds.size - size
            );
            return result;
        }
    }
}
