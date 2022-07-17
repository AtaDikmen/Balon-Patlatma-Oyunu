using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public Text zamanText, balonText, bitisText;
    public float zamanSayaci = 60;
    public GameObject patlama;
    public GameObject yenidenOyna;
    AudioSource poppingVoice;

    int patlayanBalon = 0;


    void Start()
    {
        balonText.text = "Balon: " + patlayanBalon;
        poppingVoice = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Süre: " + (int)zamanSayaci;    
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
            bitisText.text = "SÜRE DOLDU";
            yenidenOyna.SetActive(true);

        }
        

    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon: " + patlayanBalon;
        poppingVoice.Play();
    }

    public void YeniOyun()
    {
        SceneManager.LoadScene("oyun");
    }
}
