using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N : MonoBehaviour
{   public Rigidbody rb ;
    public float forwardForce = 5000f;
c
    void Start()
    {
     //   rb.useGravity = false;
    
  // Add a forward force
       
    }


    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce  * Time.deltatime);

        if (Input.Getkey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);



        }
    
    
    
    }


}
