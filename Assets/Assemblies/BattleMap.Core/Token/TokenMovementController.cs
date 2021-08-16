using UnityEngine;

namespace BattleMap.Core.Token
{
    public class TokenMovementController : MonoBehaviour
    {
        public void OnMouseDrag()
        {
            var camera = UnityEngine.Camera.main;
            var target = camera.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
        }
    }
}