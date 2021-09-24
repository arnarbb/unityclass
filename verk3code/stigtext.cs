using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stigtext : MonoBehaviour
{

    public float stig;
 

    
    public Text stigatext;

    // sínnir stig á skjánum
    void Update()
    {
        GameObject thePlayer = GameObject.Find("FPSController");
        player playerScript = thePlayer.GetComponent<player>();
        stig = playerScript.stig;
        stigatext.text =  "stig:" + stig.ToString();
    }
}
