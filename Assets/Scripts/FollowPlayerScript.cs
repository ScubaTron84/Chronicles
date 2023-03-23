using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
        /// <summary>
        /// The point of htis class is to trigger enemy objects to follow the player.
        /// </summary>
public class FollowPlayerScript : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent enemyAgent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.position);
    }
}
