using UnityEngine;

/// <summary>
/// Meðhöndlið skotið sem spilarinn hleypti af stokkunum til að laga vélmennin..
/// </summary>
public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //eyðileggja skotið þegar það nær 1000,0f fjarlægð frá upprunanum
        if(transform.position.magnitude > 1000.0f)
            Destroy(gameObject);
    }

    //stjórnandi leikmannsins hringdi í hann eftir að hann setti í gang nýja skotflaug til að skjóta henni af stað.
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Enemy e = other.collider.GetComponent<Enemy>();

        //ef hluturinn sem við snertum var ekki óvinur, bara eyðileggja skotið.
        if (e != null)
        {
            e.Fix();
        }
        
        Destroy(gameObject);
    }
}
