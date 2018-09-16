using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour {
    public List<Item> items;

     void Awake()
    {
        items.Add ( new Item("", "", 0, 0, Item.ItemType.bos));
        items.Add(new Item("anahtar", "kilitli kapıları açar", 1, 1, Item.ItemType.mazeme));
        items.Add(new Item("pil", "fener için enerji kaynağı", 2, 1, Item.ItemType.mazeme));
        items.Add(new Item("merdiven", "yükselti aşar", 3, 1, Item.ItemType.mazeme));
        items.Add(new Item("altın", "yükselti aşar", 4, 1, Item.ItemType.mazeme));
        items.Add(new Item("fener", "karanlıgı aşar", 5, 1, Item.ItemType.silah));
        items.Add(new Item("mektup", "mektup işte", 6, 1, Item.ItemType.silah));
        items.Add(new Item("Pense", "kablo kesmeye yarar", 7, 1, Item.ItemType.silah));
    }
}
