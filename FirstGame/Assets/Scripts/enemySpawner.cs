using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    private float timer = 2;

    private bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 2;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerFinished())
        {
            //Spawn Asteroid
            Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 18, 0);
            Instantiate(asteroidPrefab, spawnPosition, asteroidPrefab.transform.rotation);
        }
    }
}
