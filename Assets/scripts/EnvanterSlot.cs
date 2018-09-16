using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvanterSlot : MonoBehaviour {
    public Item item;
    public int slotSayisi;
    Envanter er;
    public Image itemicon;
    public Text itemmiktar;
    void Start()
    {
        er = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
    }
    public void Update()
    {
       // er.itemEkle(1, 1);
       
        item = er.items[slotSayisi];

        if (item.itemAdi != null)
        {
            itemicon.enabled = true;
            if (item.itemMiktar > 1)
            {
                itemmiktar.enabled = true;
            }
            itemicon.sprite = item.itemicon;
            itemmiktar.text = item.itemMiktar.ToString();
        }
        else
        {
            itemmiktar.enabled = false;
            itemicon.enabled = false;
        }


    }

}
