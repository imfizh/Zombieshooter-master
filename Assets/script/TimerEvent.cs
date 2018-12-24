using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;
  
    private void Start()
    {
        Initialize();
    }
   
    public void OnTimerComplete()
    {
            onTimerComplete.Invoke();
    }

    public void Initialize()
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
    

