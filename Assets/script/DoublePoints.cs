using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePoints : MonoBehaviour {

    private float time = 8;
    public static bool Dubpoints = false;
	void Start () {
        Dubpoints = true;
        Invoke("TimeDone", time);
    }
	
	
	void TimeDone() {
        Dubpoints = false;
        Destroy(this);
	}
}
