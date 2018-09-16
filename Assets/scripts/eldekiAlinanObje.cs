using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eldekiAlinanObje : MonoBehaviour
{
    public GameObject obj;
    public int Id;

    public eldekiAlinanObje()
    {

    }

    public eldekiAlinanObje(GameObject obj,int Id)
    {
        this.obj=obj;
        this.Id = Id;
    }
}
