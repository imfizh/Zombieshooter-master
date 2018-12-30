using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class UpgradeGun : MonoBehaviour {
    private GameUI mg;
    public int cost2 = 10;
    public delegate void SendScore(int theCost);
    public static event SendScore OnSendCost2;
    private GameObject child;
    public GameObject ru;
    public GameObject pu;
    private Animator gunAnim;
    //public GameObject pu;
    // Use this for initialization
    void Start () {
        mg = GameObject.FindGameObjectWithTag("Canvas").GetComponent<GameUI>();
        gunAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }
	
	private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Player")
        {
            if (GunBuy.yos == true)
            {
                child = GameObject.Find("Rifle");
            }
            else
            {
                child = GameObject.Find("Pistol");
            }
            mg.doorText.text = ("[E] to upgrade gun (cost: " + cost2 + ")");
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(mg.scoreText.text) >= cost2))
            {
                if (GunBuy.yos == true)
                {
                    gunAnim.SetBool("IsRifleUpgrade", true);
                    ru.SetActive(true);
                }
                else
                {
                    gunAnim.SetBool("IsPistolUpgrade", true);
                    pu.SetActive(true);
                }
                

                child.SetActive(false);
                
                OnSendCost2(cost2);
                mg.doorText.text = (" ");

            }
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (GunBuy.yos == true)
            {
                child = GameObject.Find("Rifle");
            }
            else
            {
                child = GameObject.Find("Pistol");
            }
            if (Input.GetKeyDown("e") && (System.Convert.ToInt32(mg.scoreText.text) >= cost2))
            {

                if (GunBuy.yos == true)
                {
                    gunAnim.SetBool("IsRifleUpgrade", true);
                    ru.SetActive(true);
                }
                else
                {
                    gunAnim.SetBool("IsPistolUpgrade", true);
                    pu.SetActive(true);
                }
                child.SetActive(false);
                
                OnSendCost2(cost2);
                mg.doorText.text = (" ");

            }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            mg.doorText.text = (" ");
        }
    }
}
