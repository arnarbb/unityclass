using UnityEngine;

/// <summary>
/// Þessi flokkur meðhöndlar karakter sem er ekki leikmaður. Það geymir línur þeirra af samræðum og portrettið til að birta.
/// Leikmaður stjórnandi mun hringja í Advance virka þegar spilarinn ýtir á samskiptahnappinn fyrir framan NPC
/// Framhleðsluaðgerðin mun skila ósönn svo framarlega sem ný samræðulína er til staðar, en skila sönnu þegar henni er lokið.
/// (Notað af leikmannastýringu til að loka fyrir hreyfingu þar til samtalinu er lokið)
/// </summary>
public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;
    
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
    }

    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }
    
    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
    }
}
