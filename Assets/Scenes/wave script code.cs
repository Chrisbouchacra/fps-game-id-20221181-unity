using UnityEngine;

public class wavescriptcode
{
    public class WaveManager : MonoBehaviour {
    public List<GameObject> enemyPrefabs; // Drag your Grunt, Tank, Sprinter here
    public Transform[] spawnPoints;
    public int currentWave = 0;
    private int enemiesAlive = 0;

    public void StartNextWave() {
        currentWave++; // Increment
        int count = currentWave * 5; // Escalating difficulty
        
        for (int i = 0; i < count; i++) { // For loop
            SpawnEnemy();
        }
    }

    void SpawnEnemy() {
        int randomEnemy = Random.Range(0, enemyPrefabs.Count);
        int randomPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefabs[randomEnemy], spawnPoints[randomPoint].position, Quaternion.identity);
        enemiesAlive++;
    }
}
}
