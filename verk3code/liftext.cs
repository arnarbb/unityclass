using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liftext : MonoBehaviour
{

    public float health;
    void Start()
    {

        
    }
    // þetta sýnir líf á skjónum
    
    public Text  lifText;

  
    void Update()
    {
        GameObject thePlayer = GameObject.Find("FPSController");
        player playerScript = thePlayer.GetComponent<player>();
        health = playerScript.health;
        lifText.text =  "líf:" + health.ToString();
    }
}
