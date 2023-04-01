using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;  // Reference to obstacle prefab
    public float spawnRate = 2f;  // Rate of spawning obstacles
    public float minX = -10f;  // Minimum x position for spawning obstacles
    public float maxX = 10f;  // Maximum x position for spawning obstacles
    public float minY = -5f;  // Minimum y position for spawning obstacles
    public float maxY = 5f;  // Maximum y position for spawning obstacles

    private float nextSpawnTime = 0f;  // Time for next obstacle spawn

    void Update()
    {
        // Check if it's time to spawn a new obstacle
        if (Time.time >= nextSpawnTime)
        {
            // Calculate random position for obstacle
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector2 randomPosition = new Vector2(randomX, randomY);

            // Instantiate obstacle prefab at random position
            Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);

            // Set next spawn time
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
