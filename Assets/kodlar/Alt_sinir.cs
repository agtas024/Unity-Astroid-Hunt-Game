using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alt_sinir : MonoBehaviour
{
    void OnCollisionEnter(Collision carpisma)
    {
     //   if (carpisma.gameObject.name == "tas")
        {
            Destroy(carpisma.gameObject);
        }
    }
}
