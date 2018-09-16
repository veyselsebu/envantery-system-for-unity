using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topla : MonoBehaviour {
    Envanter er;
	// Use this for initialization
	void Start () {
        er = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "pense")
        {
            er.itemEkle(7, 1);
            Destroy(nesne.gameObject);

        }

        if (nesne.gameObject.tag == "altin")
        {
            er.itemEkle(4, 1);
            Destroy(nesne.gameObject);
       
        }
        if (nesne.gameObject.tag == "fener")
        {  
            er.itemEkle(5, 1);
            Destroy(nesne.gameObject);

        }
        if (nesne.gameObject.tag == "pil")
        {
            er.itemEkle(2, 1);
            Destroy(nesne.gameObject);

        }
        if (nesne.gameObject.tag == "mektup")
        {
            er.itemEkle(6, 1);
            Destroy(nesne.gameObject);

        }
        if (nesne.gameObject.tag == "anahtar")
        {
            er.itemEkle(1, 1);
            Destroy(nesne.gameObject);

        }
    }

}
