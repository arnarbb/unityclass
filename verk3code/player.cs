
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float health = 20f;
    public GameObject explosionEffect;
    public float stig = 0;
   
    
    // þessi kóði ákveður stig og líf spilara á seigir hvernar hann dier
    
	// Þessi aðgerð keyrir þegar við höggum á annan hlut.
	// Við fáum upplýsingar um áreksturinn og köllum það „collisionInfo“
	void OnCollisionEnter (Collision collisionInfo)
	{
		// Við athugum hvort hluturinn sem við rákumst á sé með merki sem kallast „Hindrun“.
		if (collisionInfo.collider.tag == "Obstacle")
		{
			Debug.Log(health);
			Debug.Log("-10 lif");

            

            health -= 10;
            if (health <= 0f) 
            {
                Die();
                
            }


		}

        if (collisionInfo.collider.tag == "water")
		{
          
            Die();
            
        

		}

        if (collisionInfo.collider.tag == "egg")
		{
          
            win();
            
        

		}

	}
    void Die()
    {
        Explode();
        Debug.Log("dauður");
        LoadNextLevel();
    }

    void win()
    {
      
        Debug.Log("wanst");
        SceneManager.LoadScene("win");
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

    }

    public void LoadNextLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
   
    
    

   




