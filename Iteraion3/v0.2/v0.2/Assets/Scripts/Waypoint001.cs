using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint001 : MonoBehaviour
{
    public int pivot;
    public bool reverse = false;
    public Vector3 startPos = new Vector3(-15, 11, -17);

    void OnTriggerEnter(Collider e){


print(pivot);

if(e.tag == "Enemy_Mom"){

                    if(pivot == 3){
                this.gameObject.transform.position = new Vector3(-15, 14, -2);
                pivot = 0; reverse = true;

        }
        

            if(pivot == 2){
                this.gameObject.transform.position = new Vector3(-15, 14, -20);
                pivot = 3;

        }

            if(pivot == 1){
                
                this.gameObject.transform.position = new Vector3(-15, 14, -3);
                pivot = 2;

        }

            if(pivot == 0 && !reverse){

                this.gameObject.transform.position = new Vector3(2, 14, -3);
                pivot = 1;
                
            }
    reverse = false;



//print(pivot);

    }
    }
 }

