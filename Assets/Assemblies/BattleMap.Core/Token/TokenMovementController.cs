using UnityEngine;

namespace BattleMap.Core.Token
{
    public class TokenMovementController : MonoBehaviour
    {
        private Vector3 _dragDelta;

        public void OnMouseDown()
        {
            var camera = UnityEngine.Camera.main;
            var startPosition = camera.ScreenToWorldPoint(Input.mousePosition);
            _dragDelta = transform.position - startPosition;
        }

        public void OnMouseDrag()
        {
            var camera = UnityEngine.Camera.main;

            var mouseCurrent = camera.ScreenToWorldPoint(Input.mousePosition);
            var tokenCurrent = transform.position;
            var tokenTarget = mouseCurrent + _dragDelta;
            tokenTarget.z = tokenCurrent.z;
            transform.position = tokenTarget;
        }
    }
}