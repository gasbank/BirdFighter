using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public float spawnInterval = 1.0f;
    float lastSpawnTime = 0;
    public GameObject bombPrefab;
    CameraBound cameraBound;

    private void Awake()
    {
        cameraBound = Camera.main.GetComponent<CameraBound>();
    }

    private void Update()
    {
        if (Time.time - lastSpawnTime > spawnInterval)
        {
            Instantiate(bombPrefab, new Vector3(cameraBound.maxX, Random.Range(cameraBound.minY, cameraBound.maxY)), Quaternion.identity);
            lastSpawnTime = Time.time;
        }
    }
}
