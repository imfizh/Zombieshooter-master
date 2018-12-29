using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour {

    private GameUI GM;
    public GameObject door;
    public delegate void SendScore(int theCost);
    public static event SendScore OnSendCost;
    public int cost;
    public int check;
    public static bool a = false;
    public static bool b = false;
    public static bool c = false;
    
    void Start () {
        GM = GameObject.FindGameObjectWithTag("Canvas").GetComponent<GameUI>();
        
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (door == (gameObject.name == "door1" ))
            {
                cost = 500;
                
            }else if (door == (gameObject.name == "door2"))
            {
                cost = 1000;
                
            }
            else if (door == (gameObject.name == "door3"))
            {
                cost = 1500;
                
            }
            GM.doorText.text = ("[E] to open door (cost: " + cost + ")");
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(GM.scoreText.text) >= cost)) 
            {
               
                OnSendCost(cost);
                GM.doorText.text = (" ");
                if (door == (gameObject.name == "door1"))
                {
                    a = true;

                }
                else if (door == (gameObject.name == "door2"))
                {
                    b = true;

                }
                else if (door == (gameObject.name == "door3"))
                {
                    c = true;

                }
                Destroy(door);
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(GM.scoreText.text) >= cost))
            {
              
                OnSendCost(cost);
                GM.doorText.text = (" ");
                if (door == (gameObject.name == "door1"))
                {
                    a = true;

                }
                else if (door == (gameObject.name == "door2"))
                {
                    b = true;

                }
                else if (door == (gameObject.name == "door3"))
                {
                    c = true;

                }
                Destroy(door);
            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GM.doorText.text = (" ");
        }
    }
}
