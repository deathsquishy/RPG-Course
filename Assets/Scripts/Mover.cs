using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    //config
    [SerializeField] Transform target;

    //cache
    [SerializeField] NavMeshAgent myNavMeshAgent;

    //Unity Functions
    void Start()
    {
        CacheRefrences();
    }
    
    void Update()
    {
        if (target != null) { myNavMeshAgent.destination = target.position; }
    }

    //Custom Functions
    private void CacheRefrences()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

}
