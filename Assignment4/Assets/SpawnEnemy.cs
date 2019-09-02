using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = System.Random;

public class SpawnEnemy : MonoBehaviour
{
    GameObject enemy;
    Boolean enemyBack;
    Random random = new Random();
    int countTimes = 0;
    int countEnemies = 0;

    // Start is called before the first frame update
    void Start()
    { 
        countTimes = random.Next(5, 15);
        
        enemy = GameObject.Find("Enemy");

        spawnEnemies(countTimes);
    }

    // Update is called once per frame
    void Update()
    {
        enemyBack = GameObject.Find("Enemy");

    }

    void spawnEnemies(int countTimes)
    {
        StartCoroutine(CubeCoroutine(countTimes));
    }

    IEnumerator CubeCoroutine(int countTimes)
    {
        for (int a = 1; a <= countTimes; a++)
        {
            yield return new WaitForSeconds(3.0f);
            Instantiate(enemy, new Vector3(54.4f, 2.66f, 7.5f), Quaternion.identity);
        }
    }
}