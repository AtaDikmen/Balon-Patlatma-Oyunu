using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol oyunKontrolScript;

    void Start()
    {
        oyunKontrolScript = GameObject.Find("Scripts").GetComponent<OyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.250f);
        oyunKontrolScript.BalonEkle();
    }
}
