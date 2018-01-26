using UnityEngine;

public class CameraBound : MonoBehaviour
{
    public readonly float mapX = 100.0f;
    public readonly float mapY = 100.0f;

    public float minX { get; private set; }
    public float maxX { get; private set; }
    public float minY { get; private set; }
    public float maxY { get; private set; }

    private void Start()
    {
        //float vertExtent = Camera.main.orthographicSize;
        //float horzExtent = vertExtent * Screen.width / Screen.height;

        var leftBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        var rightTop = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        minX = leftBottom.x;
        maxX = rightTop.x;
        minY = leftBottom.y;
        maxY = rightTop.y;

        Debug.LogFormat("X range: {0}, {1}", minX, maxX);
        Debug.LogFormat("Y range: {0}, {1}", minY, maxY);
    }
}
