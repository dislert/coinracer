using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 1.5f;
    public float spawnY = 6f;

    public float[] lanePositions = new float[] { -4f, -1.4f, 1.4f, 4f };

    private float timer;
    private int lastLaneIndex = -1;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            int laneIndex;
            do
            {
                laneIndex = Random.Range(0, lanePositions.Length);
            } while (laneIndex == lastLaneIndex && lanePositions.Length > 1);

            lastLaneIndex = laneIndex;

            Vector3 spawnPos = new Vector3(lanePositions[laneIndex], spawnY, 0);
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        }
    }
}
