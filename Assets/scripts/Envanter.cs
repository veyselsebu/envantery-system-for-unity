using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envanter : MonoBehaviour {
    public GameObject slot;
    public List<Item> items;
    ItemData dataitem;
    public Envanter()
    {
    }
	void Start () {
        dataitem = GameObject.FindGameObjectWithTag("DataItem").GetComponent<ItemData>();
        for(int i = 0; i < 21; i++)
        {
            items.Add(new Item());
        }
    }

        public void itemEkle(int Id,int miktar)
    {
        
        for(int i = 0; i < dataitem.items.Count; i++)
        {
            if (dataitem.items[i].itemId == Id)
            {
                Item yeniitem = new Item(dataitem.items[i].itemAdi, dataitem.items[i].itemAciklama, dataitem.items[i].itemId,miktar, dataitem.items[i].itemTipi);
                bosSlotItemEkle(yeniitem);
            break;
            }
        }
    }

    public void bosSlotItemEkle(Item item)
    {
        if (item.itemTipi == Item.ItemType.silah)
        {
            for (int i = 16; i<items.Count ; i++)
            {
                if (items[i].itemId == item.itemId)
                {
                    items[i].itemMiktar += item.itemMiktar;
                    break;
                }

                if (items[i].itemAdi == null)
                {              
                    items[i] = item;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].itemId == item.itemId)
                {
                    items[i].itemMiktar += item.itemMiktar;
                    break;
                }

                if (items[i].itemAdi == null)
                {
                    items[i] = item;
                    break;

                }

            }
        }
        
    }
}
