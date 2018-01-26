using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float lastFireTime;
    public float firePerSecond = 5;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Time.time - lastFireTime > 1.0f / firePerSecond)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                lastFireTime = Time.time;
            }
        }
    }
}
