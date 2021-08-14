using Assets.Extensions;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const int DRAG_BUTTON = 1;

    private Vector3 anchor;
    private bool dragging = false;

    public float zoomSensitivity = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(DRAG_BUTTON)) OnDragStart();
        if (Input.GetMouseButtonUp(DRAG_BUTTON)) OnDragStop();
        if (dragging) OnDrag();
        var scrollDelta = Input.GetAxis("Mouse ScrollWheel");
        if (scrollDelta != 0) OnScroll(scrollDelta);
    }

    private void OnDragStart()
    {
        anchor = Input.mousePosition;
        dragging = true;
    }

    private void OnDragStop()
    {
        dragging = false;
    }

    private void OnDrag()
    {
        var motionScale = 0.1f;
        var target = (Input.mousePosition - anchor).Invert() * motionScale;
        target.z = transform.position.z;
        transform.position = target;
    }

    private void OnScroll(float scrollDelta)
    {
        Camera.main.orthographicSize -= scrollDelta * zoomSensitivity;
    }
}

