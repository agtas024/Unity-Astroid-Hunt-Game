using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sınır : MonoBehaviour
{
    // Start is called before the first frame update
    // ...Exit temas bitince;  ..Enter temas olunca;  ...Stack temas ederken çalışır.

    void OnCollisionEnter(Collision carpisma)
    {
            Destroy(carpisma.gameObject);
    }
}