using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbuys : MonoBehaviour {
    public GameObject p;
    public GameObject r;
	private void update()
    {
        print("nig");
        if (Input.GetKeyDown("e"))
        {
            print("yos");
            p.SetActive(false);
            r.SetActive(true);
        }
    }
}
