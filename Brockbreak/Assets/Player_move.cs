using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
            this.gameObject.transform.Translate(0.3f, 0, 0);
        }

        if(Input.GetKey("left")){
            this.gameObject.transform.Translate(-0.3f, 0, 0);
        }
    }
}
