using UnityEngine;

/// <summary>
/// Þessi flokkur mun beita leikmanninum stöðugum skemmdum svo framarlega sem hann er inni í kveikjunni á sama hlutnum
/// </summary>
public class DamageZone : MonoBehaviour 
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            //stjórnandi mun sjá um að hunsa tjónið á ósigrandi tíma.
            controller.ChangeHealth(-1);
        }
    }
}
