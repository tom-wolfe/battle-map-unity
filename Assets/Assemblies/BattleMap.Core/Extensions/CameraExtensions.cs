using UnityEngine;

namespace BattleMap.Core.Extensions
{
    public static class CameraExtensions
    {
        public static Bounds OrthographicBounds(this UnityEngine.Camera camera)
        {
            var screenAspect = Screen.width / (float)Screen.height;
            var cameraHeight = camera.orthographicSize * 2;
            var bounds = new Bounds(
                camera.transform.position,
                new Vector3(cameraHeight * screenAspect, cameraHeight, 0)
            );
            return bounds;
        }

        public static void KeepWithinBounds(this UnityEngine.Camera camera, Bounds bounds)
        {
            var cameraBounds = camera.OrthographicBounds();
            bounds = bounds.Deflate(cameraBounds.size);

            var cameraTarget = camera.transform.position.Clamp(bounds);
            cameraTarget.z = camera.transform.position.z;
            camera.transform.position = cameraTarget;
        }
    }

}
