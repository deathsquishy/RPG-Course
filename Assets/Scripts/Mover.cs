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
        if (Input.GetMouseButtonDown(0)) { MoveToCursor(); }
    }

    //Custom Functions
    private void MoveToCursor()
    {
        //sends out raycast, gets needed quardinates
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);

        //sends player to point in terrain that the player clicked
        if (hasHit) { myNavMeshAgent.destination = hit.point; }
    }

    private void CacheRefrences()
    { myNavMeshAgent = GetComponent<NavMeshAgent>(); }

}
