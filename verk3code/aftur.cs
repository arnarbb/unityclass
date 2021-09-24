using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aftur : MonoBehaviour
{
		
   
    // þetta settur mann aftur á byrjunar reit þegar maður ýttir á takkan
    public void PlayGame()
    {
        
        SceneManager.LoadScene("byrja");
    }

    

	void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("byrja");
        }
    }
	

 
}
