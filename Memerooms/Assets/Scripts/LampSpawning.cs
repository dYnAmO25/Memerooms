using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSpawning : MonoBehaviour
{
    [SerializeField] GameObject goLampPrefab;

    void Start()
    {
        Vector3 v3Spawn = new Vector3(-55, 0, -55);
        
        for (int i = 0; i < 10; i++)
        {
            v3Spawn = new Vector3(v3Spawn.x + 10, 0, v3Spawn.z);
            
            for (int j = 0; j < 10; j++)
            {
                v3Spawn = new Vector3(v3Spawn.x, 0, v3Spawn.z + 10);

                int k = Random.Range(-1, 2);

                if (k >= 1)
                {
                    Instantiate(goLampPrefab, v3Spawn, Quaternion.identity);
                }
            }

            v3Spawn = new Vector3(v3Spawn.x, 0, -55);
        }
    }

}
