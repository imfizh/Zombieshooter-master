using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour {
    public delegate void SendRound(int theRound);
    public static event SendRound OnSendRound;
    
    public void roundcount()
    {
        TimerEvent.numzombs -= 1;
    }
    public static void roundfin()
    {
        if(TimerEvent.numzombs == 0)
        {
            OnSendRound(TimerEvent.round);

        }
    }
    
}
