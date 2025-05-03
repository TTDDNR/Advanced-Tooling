using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private int amountToSpawn;
    [SerializeField]
    private int Spawned;
    [SerializeField]
    private GameObject toSpawn;
    void FixedUpdate()
    {
        if (amountToSpawn > 0 && Spawned < amountToSpawn)
        {
            var spawn = Instantiate(toSpawn);
            spawn.transform.position = transform.position;
            Spawned++;
        }
    }
}
