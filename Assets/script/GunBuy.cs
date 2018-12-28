﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GunBuy : MonoBehaviour {

    private GameUI gm;
    public delegate void SendScore(int theCost);
    public static event SendScore OnSendCost1;
    public int cost1;
    public int check1;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Canvas").GetComponent<GameUI>();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            gm.doorText.text = ("[E] to open door (cost: " + cost1 + ")");
            if (Input.GetKeyDown("e")) //&& (System.Convert.ToInt32(gm.scoreText.text) > cost1))
            {

                //OnSendCost1(cost1);
                gm.doorText.text = (" ");
                print("yes");
            }
         }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (Input.GetKeyDown("e"))// && (System.Convert.ToInt32(gm.scoreText.text) > cost1))
            {

                //OnSendCost1(cost1);
                gm.doorText.text = (" ");
                print("yes");
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