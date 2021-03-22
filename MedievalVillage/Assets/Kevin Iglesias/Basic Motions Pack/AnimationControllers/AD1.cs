using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AD1 : MonoBehaviour
{
    public GameObject characterDestination;
    NavMeshAgent theAgent;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        theAgent.SetDestination(characterDestination.transform.position);
    }
}