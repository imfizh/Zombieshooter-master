using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public bool repeat = false;
    public int zomb = 0;
    public int zombiesToSpawn;
    public static int round = 1;
    public static int numzombs;
    public UnityEvent onTimerComplete;
    private void Start()
    {
        Initialize();
    }
    private void OnTimerComplete()
    {
        if(zombiesToSpawn != zomb)
        {
            onTimerComplete.Invoke();
            zomb += 1;
        }
        else if (zombiesToSpawn == zomb)
        {
            CancelInvoke("OnTimerComplete");
        }
      if(numzombs == 0)
        {
            Initialize();
        } 
        
        
    }
    public void Initialize()
    {
        zomb = 0;
        zombiesToSpawn = round * 4;
        numzombs = (zombiesToSpawn * 2) - 1;
        {
            if (repeat)
            {
                InvokeRepeating("OnTimerComplete", 0, time);

            }
            else
            {
                Invoke("OnTimerComplete", time);

            }
        }
    }
}
    

