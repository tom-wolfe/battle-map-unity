using UnityEngine;

public class ZoomController : MonoBehaviour
{
    public float zoomSensitivity = 10f;
    public int maxZoom = 10;
    public int minZoom = 50;

    void Update()
    {
        var scrollDelta = Input.GetAxis("Mouse ScrollWheel");
        if (scrollDelta != 0) OnScroll(scrollDelta);
    }

    private void OnScroll(float scrollDelta)
    {
        var newZoom = Camera.main.orthographicSize - scrollDelta * zoomSensitivity;
        newZoom = Mathf.Clamp(newZoom, maxZoom, minZoom);
        Camera.main.orthographicSize = newZoom;
    }
}
