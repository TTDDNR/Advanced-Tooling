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
    void Update()
    {
        if (amountToSpawn > 0 && Spawned < amountToSpawn)
        {
                Instantiate(toSpawn);
                Spawned++;
        }
    }
}
