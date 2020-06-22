using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    //config
    [SerializeField] Transform target;
    Ray lastRay;

    //cache
    [SerializeField] NavMeshAgent myNavMeshAgent;

    //Unity Functions
    void Start()
    {
        CacheRefrences();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
        Debug.DrawRay(lastRay.origin, lastRay.direction * 100);

        //sends player off to target destination if it is not empty
        if (target != null) { myNavMeshAgent.destination = target.position; }
    }

    //Custom Functions
    private void CacheRefrences()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

}
