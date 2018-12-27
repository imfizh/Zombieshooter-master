using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour {

    private GameUI GM;
    public GameObject door;
    
	void Start () {
        GM = GameObject.FindGameObjectWithTag("Canvas").GetComponent<GameUI>();
        
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        
            print("yes");
        if (col.gameObject.name == "Player")
        {
            
            GM.doorText.text = ("[E] to open door (cost:750)");
            if (Input.GetKeyDown("e"))
            {
                GM.doorText.text = (" ");
                //door.GetComponent<CircleCollider2D>().isTrigger = false;
                //Destroy(door.GetComponent<CircleCollider2D>());
                //b.SetActive(false);
                Destroy(door);
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                GM.doorText.text = (" ");
                //b.SetActive(false);
                //door.GetComponent<CircleCollider2D>().isTrigger = false;
                //Destroy(door.GetComponent<CircleCollider2D>());
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
