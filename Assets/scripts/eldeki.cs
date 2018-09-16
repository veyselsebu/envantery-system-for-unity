using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eldeki : MonoBehaviour {
    public Item item;
    Envanter er;
    public Image itemicon;
    public int Id;
    public Sprite resim;
    public List<eldekiAlinanObje>eldekiobj;
    public GameObject PilPaneli;
    void Start () {
        er = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
        eldekiObje(0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            itemicon.enabled = true;
            itemicon.sprite = resim;
            eldekiObje(0);
           
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            itemicon.enabled = true;
            item = er.items[16];
            itemicon.sprite = item.itemicon;
            Id = item.itemId;
            eldekiObje(Id);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            item = er.items[17];
            itemicon.sprite = item.itemicon;
            Id = item.itemId;
            eldekiObje(Id);
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            item = er.items[18];
            itemicon.sprite = item.itemicon;
            Id = item.itemId;
            eldekiObje(Id);
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            item = er.items[19];
            itemicon.sprite = item.itemicon;
            Id = item.itemId;
            eldekiObje(Id);


        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            item = er.items[20];
            itemicon.sprite = item.itemicon;
            Id = item.itemId;
            eldekiObje(Id);

        }

    }

    public void eldekiObje(int Id)
    {
        if (Id == 5)
        {
            PilPaneli.SetActive(true);

        }
        else
        {
            PilPaneli.SetActive(false);
        }
        if (Id == 0)
        {
            for (int i= 0;i< eldekiobj.Count; i++)
            {
                eldekiobj[i].obj.SetActive(false);
            }
        }
        else {


            for(int i = 0;i< eldekiobj.Count; i++)
            {
                if (Id == eldekiobj[i].Id)
                {
                    eldekiobj[i].obj.SetActive(true);
                }
                else
                {
                    eldekiobj[i].obj.SetActive(false);
                }

            }


        }

   


    }
}
