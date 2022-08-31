using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGadget : MonoBehaviour
{

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Outside");
        if (collision.gameObject.tag=="PlayStation")
        {
            Debug.Log("Inside");
            Destroy(collision.gameObject);
        }
        
    }*/

    private void  OnControllerColliderHit(ControllerColliderHit collision)
    {
        
        if (collision.gameObject.tag == "PlayStation")
        {
           
            Destroy(collision.gameObject);
        }
    }
}
