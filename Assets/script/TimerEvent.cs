using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public bool repeat = false;
    //public int zomb = 0;
    //public int zombiesToSpawn;
    //public static int round = 1;
    //public static int numzombs;
    //public static bool roundOVER = false;
    public UnityEvent onTimerComplete;
  
    private void Start()
    {
        Initialize();
    }
    //private void Update()
    //{
        
    //    if (roundOVER==true)
    //    {
    //        roundOVER = false;
            
    //        Initialize();
            
    //    }
    //}
    public void OnTimerComplete()
    {
        //if(zombiesToSpawn != zomb)
        //{
            onTimerComplete.Invoke();
        //    zomb += 1;
            
        //}
        //else if (zombiesToSpawn == zomb)
        //{
            //CancelInvoke("OnTimerComplete");
            
        //}


    }

    public void Initialize()
    {
        //zomb = 0;
        //zombiesToSpawn = round * 2;
        //numzombs = (zombiesToSpawn * 2);
        //{
            if (repeat)
            {
                InvokeRepeating("OnTimerComplete", 0, time);
          

            }
            else
            {
                Invoke("OnTimerComplete", time);

            }
        //}
    }
}
    

