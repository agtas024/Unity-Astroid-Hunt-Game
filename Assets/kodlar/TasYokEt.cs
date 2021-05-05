using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TasYokEt : MonoBehaviour
{
    public GameObject ucak_patlat;
    public GameObject patlat;
    GameObject OyunKontrol;
    OyunKontrol kontrol;
    void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<OyunKontrol>();

    }
    void OnCollisionEnter(Collision carpisma)
    {
        if (carpisma.gameObject.name == "Player")
        {
            Destroy(carpisma.gameObject);
            Instantiate(ucak_patlat, transform.position, transform.rotation);
            kontrol.Oyun_Bitti();

        }
        Destroy(this.gameObject);
        Instantiate(patlat, transform.position, transform.rotation);
        if (carpisma.gameObject.name != "Alt_sinir" && carpisma.gameObject.name!="tas")
        {
            kontrol.puanarttır(3);
        }
        else if (carpisma.gameObject.name == "Alt_sinir")
        {
            kontrol.puanarttır(-2);
        }
    }
}