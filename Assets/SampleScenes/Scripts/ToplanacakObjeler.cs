using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanacakObjeler : MonoBehaviour {
    public static int objeler = 0;

    private void Awake()
    {
        objeler++;
    }
    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            objeler--;
            gameObject.SetActive(false);
        }
    }
   
}
