using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scr : MonoBehaviour {

    public GameObject isik;
    public pil pl;
    public bool acikmi;
	void Start () {
      pl = GameObject.FindGameObjectWithTag("pilgostergesi").GetComponent<pil>();
        isik.SetActive(false);
    
}

    // Update is called once per frame
    void Update()
    {
        if (isik.activeSelf)
        {
            pl.pilazalt();
        }

        if (pl.pilSeviyesi < 1)
        {
            pl.pilSeviyesi = 0;
            isik.SetActive(false);
        }
        else
        {


            if (Input.GetKeyDown(KeyCode.F))
            {
                if (isik.activeSelf)
                {
                    isik.SetActive(false);
                }
                else
                {
                   
                    isik.SetActive(true);
                }

            }
        }
    }
}
