using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoundController : MonoBehaviour {

    public int totalZombies = 6;
    public int add = 6;
    public delegate void SendScore(int theRound);
    public static event SendScore OnSendRound;
    public int Round = 1;
    List<int> var = new List<int>(new int[] {0, 1, 2 });
    public UnityEvent onRoundComplete;

	public void SpawnZombie ()
    {
        totalZombies--;
        //transform.childCount
        //int randomSpawnPoint = Random.Range(0, var.count);
        whichSpawners();
        int randomSpawnPoint = var[Random.Range(0, var.Count)];
        print(randomSpawnPoint);
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
        if (totalZombies < 24)
        {
            add = add + 6;
            totalZombies = totalZombies + add;
        }
       
        OnSendRound(Round);
    }
    public void whichSpawners()
    {
        if (Doors.a == true)
        {
            var.Add(3);
            var.Add(4);
        }
        if (Doors.b == true)
        {
            var.Add(5);
            var.Add(6);
        }
        if (Doors.c == true)
        {
            var.Add(7);
            var.Add(8);
        }
    }

}
