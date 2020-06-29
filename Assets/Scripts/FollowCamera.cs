using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //cache refrences
    [SerializeField] GameObject target;

    //Unity Functions
     void Update()
    {
        transform.position = target.transform.position;
    }
}
