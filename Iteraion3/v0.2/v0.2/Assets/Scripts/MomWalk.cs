using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MomWalk : MonoBehaviour
{
    public GameObject dest;
    NavMeshAgent Agent;

    // Update is called once per frame
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        Agent.SetDestination(dest.transform.position);
    }
}
