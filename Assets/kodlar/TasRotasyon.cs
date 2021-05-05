using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasRotasyon : MonoBehaviour
{
    Rigidbody fizik;
    void Start()
    {
        fizik=GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*4;
    }
}
