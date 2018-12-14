using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZombieManager : MonoBehaviour {

    public UnityEvent onAllZombiesKilled;
	
	public void CheckZombiesAreDead()
    {
        InvokeRepeating("CheckNumberOfZombies", 0, 1);
    }


    void CheckNumberOfZombies()
    {
        int children = transform.childCount;

        

        if (children < 1)
        {
            // player has won
            onAllZombiesKilled.Invoke();
            CancelInvoke("CheckNumberOfZombies");
            print("all zombies deaded");
        }
    }
}
