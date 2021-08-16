using UnityEngine;

namespace BattleMap.Core.Camera
{
    public class CameraPanController : MonoBehaviour
    {
        private Vector3 _mouseStart;

        public void OnMouseDown()
        {
            var camera = UnityEngine.Camera.main;
            _mouseStart = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        public void OnMouseDrag()
        {
            var camera = UnityEngine.Camera.main;

            var mouseCurrent = camera.ScreenToWorldPoint(Input.mousePosition);
            var dragDelta = _mouseStart - mouseCurrent;
            var cameraCurrent = camera.transform.position;
            var cameraTarget = cameraCurrent + dragDelta;
            cameraTarget.z = cameraCurrent.z;
            camera.transform.position = cameraTarget;
        }
    }
}