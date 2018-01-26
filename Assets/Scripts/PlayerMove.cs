using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f;
    public CameraBound cameraBound;

    private void Update()
    {
        //Debug.LogFormat("H {0}, V {1}", Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        Vector3 p = transform.position;
        p.x = Mathf.Clamp(p.x, cameraBound.minX, cameraBound.maxX);
        p.y = Mathf.Clamp(p.y, cameraBound.minY, cameraBound.maxY);
        transform.transform.position = p;
    }
}
