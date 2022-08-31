using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomWalk : MonoBehaviour
{
    int current = 0;
    public GameObject[] wapoints;
    float rotationSpeed;
    public float speed;
    float wpradius=1;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Here");
        if(Vector3.Distance(wapoints[current].transform.position, transform.position) < wpradius)
            {
            current++;
            if(current<= wapoints.Length)
            {
                current = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,wapoints[current].transform.position, Time.deltaTime*speed);
        }
    }
}
