using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class movement : MonoBehaviour
{
    Vector3 path_destination;
    Vector3 destination_vector;
    Ray ray;
    RaycastHit moveData = new RaycastHit();
    NavMeshAgent agent;
    
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
       path_destination = transform.position;
    }
    void Update()
    {
        //
        //Mouse input for movement
        //
        if(Input.GetButtonDown("Move")){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out moveData);
            Debug.DrawRay(ray.origin,ray.direction*10);
            path_destination = moveData.point;
        }
        
        agent.destination = path_destination;
    }
}
