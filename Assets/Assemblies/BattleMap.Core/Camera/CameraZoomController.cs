using BattleMap.Core.Extensions;
using UnityEngine;

namespace BattleMap.Core.Camera
{
    public class CameraZoomController : MonoBehaviour
    {
        public float zoomSensitivity = 10f;
        public int maxZoom = 10;
        public int minZoom = 50;

        public void Update()
        {
            var scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            if (scrollDelta != 0) OnScroll(scrollDelta);
        }

        private void OnScroll(float scrollDelta)
        {
            var camera = UnityEngine.Camera.main;
            var newZoom = camera.orthographicSize - scrollDelta * zoomSensitivity;
            newZoom = Mathf.Clamp(newZoom, maxZoom, minZoom);
            camera.orthographicSize = newZoom;

            var mapBounds = GetComponent<Collider2D>().bounds;
            camera.KeepWithinBounds(mapBounds);
        }
    }
}