using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GunBuy : MonoBehaviour {

    private GameUI gm;
    public delegate void SendScore(int theCost);
    public static event SendScore OnSendCost1;
    public int cost1 = 10;
    public GameObject p;
    public GameObject r;
    private Animator gunAnim;
   
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Canvas").GetComponent<GameUI>();
        gunAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            gm.doorText.text = ("[E] to buy MP40 (cost: " + cost1 + ")");
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(gm.scoreText.text) >= cost1))
            {
                p.SetActive(false);
                r.SetActive(true);
                gunAnim.SetBool("IsRifle", true);
                
                OnSendCost1(cost1);
                gm.doorText.text = (" ");
                
            }
         }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(gm.scoreText.text) >= cost1))
            {
                p.SetActive(false);
                r.SetActive(true);
                gunAnim.SetBool("IsRifle", true);
                
                OnSendCost1(cost1);
                gm.doorText.text = (" ");
                
            }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            gm.doorText.text = (" ");
        }
    }
}
