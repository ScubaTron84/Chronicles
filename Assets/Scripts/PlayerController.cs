using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent playerAgent;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPosition;
            
            //Check if mouse clicked something real
            if(Physics.Raycast(ray, out hitPosition))
            {
                //move our agent
                playerAgent.SetDestination(hitPosition.point);
            }
        }
    }
}
