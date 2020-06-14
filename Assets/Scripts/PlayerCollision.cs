using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            movement.rb.velocity = new Vector3(0,0,0);
            
            FindObjectOfType<GameManagerEngine>().EndGame();
        }
    }
}
