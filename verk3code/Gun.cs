
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float demage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    // þetta er bissan sem tekur líf af því sem er skotið á
    void Update()
    {
        if ( Input.GetButtonDown("Fire1"))
        {

            Shoot();
        }


    }


    


    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);


            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(demage);
            }
        }


    }
}
