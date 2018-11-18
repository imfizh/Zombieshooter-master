using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public bool repeat = false;
    public int zomb = 0;
    public UnityEvent onTimerComplete;
    private void Start()
    {

        {
            if (repeat)
            {
                InvokeRepeating("OnTimerComplete", 0, time);
                zomb += 1;
            }
            else
            {
                Invoke("OnTimerComplete", time);
                zomb += 1;
            }
        }


        }
        private void OnTimerComplete()
        {
            onTimerComplete.Invoke();
            zomb += 1;
        if (zomb >= 5)
        {
            CancelInvoke();
        }
    }
    }
    
