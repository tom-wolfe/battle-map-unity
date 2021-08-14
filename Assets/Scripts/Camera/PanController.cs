using UnityEngine;

public class PanController : MonoBehaviour
{
    private const int DRAG_BUTTON = 0;

    private Vector3 _mouseStart;
    private bool _dragging = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(DRAG_BUTTON)) OnDragStart();
        if (Input.GetMouseButtonUp(DRAG_BUTTON)) OnDragStop();
        if (_dragging) OnDrag();
    }

    private void OnDragStart()
    {
        _mouseStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _dragging = true;
    }

    private void OnDragStop()
    {
        _dragging = false;
    }

    private void OnDrag()
    {
        var mouseCurrent = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var dragDelta = _mouseStart - mouseCurrent;
        var cameraCurrent = transform.position;
        var cameraTarget = cameraCurrent + dragDelta;
        cameraTarget.z = cameraCurrent.z;
        transform.position = cameraTarget;
    }
}

