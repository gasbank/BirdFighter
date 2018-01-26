using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 8.0f;
    CameraBound cameraBound;

    private void Awake()
    {
        cameraBound = Camera.main.GetComponent<CameraBound>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x > cameraBound.maxX)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
