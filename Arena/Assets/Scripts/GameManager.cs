using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject[] weapons;
    public GameObject enemy;
    public string playerName;

    private int waveCount;
    public int WaveCount
    {
        get { return waveCount; }
        set { waveCount = value; }
    }

    private int enemyCount;

    public int EnemyCount
    {
        get { return enemyCount; }
        set { enemyCount = value; }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);        
    }

    public void SpawnEnemies()
    {        
        for (enemyCount = 0; enemyCount < 10; enemyCount++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-17, 17), 0, Random.Range(43, 77)), transform.rotation);
        }
    }
}
