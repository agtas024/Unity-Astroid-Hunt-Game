using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0, vertical = 0, zaman = 0;
    Vector3 vec;
    public float carpim, minX, maxX, minY, maxY, egim, atış_zamanı; //minX=-6.52, maxX=6.52, minY=-4.11, maxY=3.77
    public GameObject kursun;
    public Transform topun_agzi_sag;
    public Transform topun_agzi_sol;
    AudioSource audio;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time > zaman)
        {
            zaman = Time.time + atış_zamanı; //ateş etme sürekli aktif olmasın diye. Atışlar arası 1 s beklemek için.
            Instantiate(kursun, topun_agzi_sag.position, Quaternion.identity);   //object,pozisyon ve rotasyon olmak üzere üç parametre alan bi metotdur(Instantiate). 
            audio.Play();
        }
        else if (Input.GetButton("Fire1") && Time.time > zaman)
        {
            zaman = Time.time + atış_zamanı;
            Instantiate(kursun, topun_agzi_sol.position, Quaternion.identity);
            audio.Play();
        }
        else if (Input.GetButton("Fire1") && Input.GetButton("Fire2") && Time.time > zaman)
        {
            zaman = Time.time + atış_zamanı;
            Instantiate(kursun, topun_agzi_sag.position, Quaternion.identity);
            Instantiate(kursun, topun_agzi_sol.position, Quaternion.identity);
            audio.Play();
        }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(-horizontal, vertical, 0);
        fizik.velocity = vec * carpim;
        fizik.position = new Vector3(Mathf.Clamp(fizik.position.x, minX, maxX), Mathf.Clamp(fizik.position.y, minY, maxY), 0.0f);
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x * (-egim));
    }
}