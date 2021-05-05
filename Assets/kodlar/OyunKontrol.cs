using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Astroids;
    int puan;
    public Text text,text0;
    Boolean Oyun_Bitti_mi = false, yeniden = false;
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);//2 saniye bekler
        while (true)
        {
            for (int i = 0; i < 4; i++)
            {
                Vector3 vec = new Vector3(UnityEngine.Random.Range(-63 / 10, 63 / 10), 4, 0);//oyun ekranında -6,3 ve 6,3 arasında ve y de 7 değerinden doğacak taşlar
                Instantiate(Astroids, vec, Quaternion.identity);
                yield return new WaitForSeconds(15 / 10);
                if (Oyun_Bitti_mi)
                {
                    yeniden = true;
                    text0.text = "Yandınız. (Start=B)";
                    break;
                    
                }
            }
            yield return new WaitForSeconds(2);
        }
    }
    void Start()
    {
        puan = 0;
        text.text = "PUAN = " + puan;
        text0.text = "";
        StartCoroutine(olustur());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)&&yeniden){//oyunu yenden baslatma
            SceneManager.LoadScene("level1");
        }
    }
    public void puanarttır(int gelenpuan)
    {
        puan += gelenpuan;
        text.text = "PUAN = " + puan;
    }
    public void Oyun_Bitti()
    {
        Oyun_Bitti_mi = true;
    }
}
