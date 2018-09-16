using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class acKapa : MonoBehaviour {
    public GameObject panel;
    public GameObject panel1;
    public GameObject panel2;
    public bool envanterAcikMi;
	// Use this for initialization
	void Start () {
        envanterAcikMi = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (envanterAcikMi == true)
            {
                panel2.SetActive(false);
                panel1.SetActive(false);
                panel.SetActive(false);
                envanterAcikMi = false;
            }
            else
            {

                envanterAcikMi = true;
                panel2.SetActive(true);
                panel1.SetActive(true);
                panel.SetActive (true);
            }

        }
	}
}
