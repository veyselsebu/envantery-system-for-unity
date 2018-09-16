using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pil : MonoBehaviour {
    public float pilSeviyesi;
    public Text text;
    public Envanter er;
    public GameObject isik;
    public int t;
	void Start () {
        er = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
        pilSeviyesi = 0;
        t = 0;
	}
	void Update () {
       t=(int) pilSeviyesi;
        yazdir();
        if (pilSeviyesi == 0)
        {
            pilYukle();
        }  
	}

public void pilYukle()
    {
        for(int i = 0; i < er.items.Count; i++)
        {
            if (er.items[i].itemId == 2)
            {
                pilSeviyesi = 100;
                er.items[i].itemMiktar--;
                if (er.items[i].itemMiktar==0)
                {
                    er.items[i] = new Item("", "", 0, 0, Item.ItemType.bos);
                }
            }
        }
    }
    public void pilazalt()
    {
        pilSeviyesi -= ((Time.time/100)/100);    
    }
public void yazdir()
    {
        text.text = ""+t;
    }


}
