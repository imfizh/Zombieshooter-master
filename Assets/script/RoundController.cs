using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoundController : MonoBehaviour {

    public int totalZombies = 3;
    public delegate void SendScore(int theRound);
    public static event SendScore OnSendRound;
    public int Round = 1;
    public UnityEvent onRoundComplete;

	public void SpawnZombie ()
    {
        totalZombies--;
        int randomSpawnPoint = Random.Range(0, transform.childCount);

        Transform spawner = (transform.GetChild(randomSpawnPoint));

        spawner.GetComponent<Spawner>().Spawn();
        
        if (totalZombies < 1)
        {
            // when all zombies spawned
            onRoundComplete.Invoke();
            
        }
    }
    public void boi()
    {
        totalZombies = 4;
        OnSendRound(Round);
    }
    
}
