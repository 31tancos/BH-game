using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public float SpawnDelay;
    public float SpawnCount;
    public GameObject Enemy;
    public float SpawnInterval;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(SpawnDelay);
        for (int i = 0; SpawnCount > i; i++)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(SpawnInterval);
        }
    }
}