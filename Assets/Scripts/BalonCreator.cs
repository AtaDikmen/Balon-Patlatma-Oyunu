using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonCreator : MonoBehaviour
{
    public GameObject balon;
    float balonCreateTime = 1f;
    float timecounter = 0;
    OyunKontrol okScript;
    void Start()
    {
        okScript = this.gameObject.GetComponent<OyunKontrol>();
    }

    
    void Update()
    {
        timecounter -= Time.deltaTime;
        int katsayi = (int)(okScript.zamanSayaci / 10)- 6;
        katsayi *= -1;

        if (timecounter < 0 && okScript.zamanSayaci > 0 )
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.25f,2.25f), Random.Range(-5.79f,-7.42f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(50f * katsayi, 80f * katsayi), 0));

            if (okScript.zamanSayaci < 40 && okScript.zamanSayaci > 30)
            {
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
            }
            else if (okScript.zamanSayaci < 30 && okScript.zamanSayaci > 20)
            {
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
            }
            else if (okScript.zamanSayaci < 20 && okScript.zamanSayaci > 10)
            {
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
            }
            else if (okScript.zamanSayaci < 10)
            {
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
                go = Instantiate(balon, new Vector3(Random.Range(-2.25f, 2.25f), Random.Range(-8f, -9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
            }

            timecounter = balonCreateTime;

        }
    }
}
