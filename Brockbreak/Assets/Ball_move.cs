using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody> ();
        Vector3 force = new Vector3 (300.0f,0.0f,-600.0f);
        rb.AddForce (force); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Box"){
            Destroy(collision.gameObject);
        }
    }
}
