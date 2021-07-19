using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject zombPrefab;
    public GameObject[] spawnPoint;

    private void Start()
    {
        InvokeRepeating("spawnZombie", 3f, 5f);
    }

    void spawnZombie()
    {
        AudioManager.PlayAudio("zombieSpawn");
        Instantiate(zombPrefab, spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);
    }
}
