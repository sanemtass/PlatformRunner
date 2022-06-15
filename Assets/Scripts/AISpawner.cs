using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    public int numberToSpawn;
    public GameObject aiSpawn;
    public float waitTime;

    void Start()
    {
        StartCoroutine(SpawnAI());
    }

    IEnumerator SpawnAI()
    {
        while (numberToSpawn > 0)
        {
            Instantiate(aiSpawn, transform.position, transform.rotation);
            yield return new WaitForSeconds(waitTime);
            numberToSpawn--;
        }
    }
}
