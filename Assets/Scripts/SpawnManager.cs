using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    float time;

    private void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5f)
        {
            GameObject enemyFromPool = ObjectPool.Instance.GetObjectsFromPool("Enemy");
            enemyFromPool.SetActive(true);
            time = 0f;
        }
    }
} 

