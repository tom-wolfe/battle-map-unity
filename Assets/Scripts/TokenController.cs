using UnityEngine;

public class TokenController : MonoBehaviour
{
    void OnMouseDrag()
    {
        var target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;
        transform.position = target;
    }
}
