using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform SpawnerLeft, SpawnerRight;

    public GameObject DropItem;

    public void RandomSpawn()
    {
        var RandomPosX = Random.Range(SpawnerLeft.transform.position.x, SpawnerRight.transform.position.x);

        Instantiate(DropItem, new Vector3(RandomPosX, SpawnerLeft.transform.position.y, 0), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomSpawn", 0.0f, Random.Range(1.5f, 2.5f));
    }


}
