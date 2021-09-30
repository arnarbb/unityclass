using UnityEngine;

/// <summary>
/// Mun sjá um að gefa persónunni heilsu þegar hún kemur inn á kveikjuna
/// </summary>
public class HealthCollectible : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
