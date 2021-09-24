
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;
    public GameObject explosionEffect;
    
    public float stig;

    
    
    

 

    void star()
    {

    }


    // líf hjá óvinum og spreingir þá þegar þeir deyja
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f) 
        {   
            
            Die();
            
        }
    }
    
    void Die()
    {
        GameObject thePlayer = GameObject.Find("FPSController");
        player playerScript = thePlayer.GetComponent<player>();
        playerScript.stig += 10f;
        
        Debug.Log(stig);
        Explode();
        Destroy(gameObject);
        
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

    }

}
