using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjeSayici : MonoBehaviour {

    public GameObject objText;
	// Use this for initialization
    
	void Start () {
        objText = GameObject.Find("ObjeSayac");
	}
	
	// Update is called once per frame
	void Update () {
        objText.GetComponent<Text>().text = ToplanacakObjeler.objeler.ToString();
        if (ToplanacakObjeler.objeler == 0) {
            objText.GetComponent<Text>().text = "Bütün Objeleri topladın Tebrikler!!!";
            Application.LoadLevel(0);
        }
        if (Input.GetKey(KeyCode.O))
        {
            ToplanacakObjeler.objeler = 0;
        }
    }
}
