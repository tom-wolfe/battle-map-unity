using BattleMap.Core.Extensions;
using UnityEngine;

namespace BattleMap.Core.Camera
{
    public class CameraPanController : MonoBehaviour
    {
        private Vector3 _dragStart;

        public void OnMouseDown()
        {
            var camera = UnityEngine.Camera.main;
            _dragStart = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        public void OnMouseDrag()
        {
            var camera = UnityEngine.Camera.main;

            var mouseCurrent = camera.ScreenToWorldPoint(Input.mousePosition);
            var dragDelta = _dragStart - mouseCurrent;
            var cameraCurrent = camera.transform.position;
            var cameraTarget = cameraCurrent + dragDelta;
            camera.transform.position = cameraTarget;

            var mapBounds = GetComponent<Collider2D>().bounds;
            camera.KeepWithinBounds(mapBounds);
        }
    }
}