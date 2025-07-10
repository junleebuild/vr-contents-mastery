using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerupPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefabs, GenerateSpawnPosition(), powerupPrefabs.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++; SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefabs, GenerateSpawnPosition(), powerupPrefabs.transform.rotation);
        }
    }

    void SpawnEnemyWave(int ememiesToSpawn)
    {
        for (int i = 0; i < ememiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

        }
    }
    
    private Vector3 GenerateSpawnPosition()
    
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosz = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosz);

        return randomPos;
    }
}
