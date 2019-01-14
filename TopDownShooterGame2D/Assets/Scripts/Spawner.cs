﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public int SpawnAllowed = 0;
    private int EnemyNormalAmount = 0;

    public void Update()
    {
        EnemyNormalAmount = GameObject.FindGameObjectsWithTag("EnemyNormal").Length;
    }

    public void EnemyLimit()
    {
        if (EnemyNormalAmount < SpawnAllowed)
        {
            Spawn();
        }
        else
        {

        }
    }

    public void Spawn()
    {
            Vector3 rotationInDegrees = transform.eulerAngles;
            rotationInDegrees.z += adjustmentAngle;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(Prefab, transform.position, rotationInRadians);
    }
}
