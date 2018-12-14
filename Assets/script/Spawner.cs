using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefabToSpawn;

    public Transform parent;

    public float adjustmentAngle = 0;
    public void Spawn()
    {
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
