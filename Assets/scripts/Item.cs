using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item {
    public string itemAdi, itemAciklama;
    public int itemId, itemMiktar;
    public  Sprite itemicon;
    public ItemType itemTipi;
    public GameObject itemModel;
    public enum ItemType
    {
        bos,
        silah,
        mazeme,
        yiyecek
    }
    public Item()
    {

    }
    public Item(string itemAdi,string itemAciklama,int itemId,int itemMiktar,ItemType itemTipi)
    {

        this.itemAdi = itemAdi;
        this.itemAciklama = itemAciklama;
        this.itemId = itemId;
        this.itemMiktar = itemMiktar;
        itemicon = Resources.Load<Sprite>(itemId.ToString());
        itemModel = Resources.Load<GameObject>("kup");
        this.itemTipi = itemTipi;
    }
	
}
