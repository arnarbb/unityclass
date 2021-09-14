using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notCoin : MonoBehaviour
{

    float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerMovement>().points--;
            //add 1 to points.
            Destroy(gameObject); // this distroys things
        }
    }
}
