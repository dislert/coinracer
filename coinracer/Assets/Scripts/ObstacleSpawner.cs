using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;  
    public GameObject coinPrefab;      

    public float spawnInterval = 1.5f;
    private float timer = 0f;

    private float[] lanes = { -4f, -1.4f, 1.4f, 4f };

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            int laneIndex = Random.Range(0, lanes.Length);
            float laneX = lanes[laneIndex];
            Vector3 spawnPos = new Vector3(laneX, 6f, 0f);

            if (Random.value < 0.5f)
            {
                Instantiate(coinPrefab, spawnPos, Quaternion.identity);
            }
            else
            {
                Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
            }

            timer = 0f;
        }
    }
}
