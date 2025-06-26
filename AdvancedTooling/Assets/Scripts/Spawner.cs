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
            for (int i = 0; 100 >= i; i++)
            {
                for (int j = 0; 100 >= j; j++)
                {
                    if (Spawned < amountToSpawn)
                    {
                        var spawn = Instantiate(toSpawn);
                        spawn.transform.position = transform.position + new Vector3(i, 0, j);
                        Spawned++;
                    }
                }
            }
        }
    }
}
