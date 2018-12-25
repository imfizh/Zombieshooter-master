﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Drops : MonoBehaviour {

    public GameObject prefabToSpawn;

    public Transform parent;

    public float adjustmentAngle = 0;
    
    

    public void Spawn()
    {
        
        int numb = Random.Range(0, 11);
        print(numb);
        if (numb == 10) {
            
            Vector3 rotationInDegrees = transform.eulerAngles;
            rotationInDegrees.z += adjustmentAngle;
            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

            if (parent == null)
            {
                Instantiate(prefabToSpawn, transform.position, rotationInRadians);
            }
            else
            {
                Instantiate(prefabToSpawn, transform.position, rotationInRadians, parent);
            }

        }
    }
}


