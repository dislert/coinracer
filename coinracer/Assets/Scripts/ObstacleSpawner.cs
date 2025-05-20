using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject coinPrefab;
    public float spawnInterval = 1.5f;

    private float timer;
    private int previousLane = -1;
    private float[] lanePositions = new float[] { -4f, -1.4f, 1.4f, 4f };

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        int laneIndex;

        // ¬ыбираем случайную полосу, отличную от предыдущей
        do
        {
            laneIndex = Random.Range(0, lanePositions.Length);
        } while (laneIndex == previousLane);

        previousLane = laneIndex;

        float spawnY = Camera.main.transform.position.y + 6f; // выше камеры
        Vector3 spawnPos = new Vector3(lanePositions[laneIndex], spawnY, 0f);


        // 50% шанс: либо монета, либо преп€тствие
        float chance = Random.value;

        if (chance < 0.5f)
        {
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            Instantiate(coinPrefab, spawnPos, Quaternion.identity);
        }
    }
}
