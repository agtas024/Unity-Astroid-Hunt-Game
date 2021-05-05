using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursunKONTROL : MonoBehaviour
{
    Rigidbody fizik;
    void Start()
    {   //kurşun bi kere çalışacağından update metodu yazmadık
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = new Vector3(0, 1, 0) * 12;
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "tass")
        {
            Destroy(this.gameObject);
        }
    }
}