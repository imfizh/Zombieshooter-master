using Pathfinding;
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
    public GameObject zombie;
    private TimerEvent increase;
    public int i;
    private void Start()
    {
        zombie.GetComponent<HealthSystem>().health = 6;
        zombie.GetComponent<AILerp>().speed = 2;
        increase = GameObject.FindGameObjectWithTag("Round Controller").GetComponent<TimerEvent>();
    }
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
        if (add< 24)
        {
            add = add + 6;
        }
        totalZombies = totalZombies + add;
        if (GameUI.round1 == 3)
        {
            zombie.GetComponent<HealthSystem>().health = 8;
            zombie.GetComponent<AILerp>().speed = 2.5f;
            increase.time = 1.5f;
        }
        if (GameUI.round1 == 7)
        {
            zombie.GetComponent<HealthSystem>().health = 10;
            zombie.GetComponent<AILerp>().speed = 3f;
            increase.time = 0.75f;
        }
        OnSendRound(Round);
    }
    public void whichSpawners()
    {
        if (Doors.a == true)
        {
            var.Add(3);
            var.Add(4);
            i++;
            if (i == 3)
            {
                Doors.a = false;
            }
            
        }
        if (Doors.b == true)
        {
            var.Add(5);
            var.Add(6);
            Doors.b = false;
        }
        if (Doors.c == true)
        {
            var.Add(7);
            var.Add(8);
            var.Add(9);
            var.Add(10);
            Doors.c = false;
        }
    }

}
