using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGadget : MonoBehaviour
{

    

    private void  OnControllerColliderHit(ControllerColliderHit collision)
    {
        
        if (collision.gameObject.tag == "PlayStation")
        {
           
            Destroy(collision.gameObject);
        }
    }
}
