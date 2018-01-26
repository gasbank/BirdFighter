using UnityEngine;

public class BombMove : MonoBehaviour
{
    public float speed = 5.0f;
    CameraBound cameraBound;

    private void Awake()
    {
        cameraBound = Camera.main.GetComponent<CameraBound>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
        if (transform.position.x < cameraBound.minX)
        {
            Destroy(gameObject);
        }
    }
}
