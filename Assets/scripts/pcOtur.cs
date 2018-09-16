using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pcOtur : MonoBehaviour {
    public Text yazi;
    public AudioClip eyebas,kacma,giris;
    public AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("uyari1"))
        {
            yazi.text = "Sakın Dışarıya Kaçmayı Deneme !!!";
            audio.PlayOneShot(kacma);
        }
        if (other.gameObject.CompareTag("pcOtur"))
        {
            yazi.text = "Bilgisayarı kullanmak için e ye bas";
            audio.PlayOneShot(eyebas);
        }
        if (other.gameObject.CompareTag("baslangic"))
        {
            Destroy(other.gameObject);
            audio.PlayOneShot(giris);
        }
        if (other.gameObject.CompareTag("hangarGecis"))
        {
            Application.LoadLevel("ssda");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("pcOtur") || other.gameObject.CompareTag("uyari1"))
        {
            yazi.text = "";
        }
    }
    public void OnTriggerStay(Collider other)
    {
        //-------------
        if (other.gameObject.CompareTag("pcOtur"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(1);
                
            }
        }
    }
    }
