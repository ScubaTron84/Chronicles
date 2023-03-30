using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ONLY USED FOR KEYBOARD NAVIGATION GAMES
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    private Transform _tranformer;
    public Rigidbody rb;
    private float speed = 20f;
    public float forwardForce;
    public float sideWaysForce;

    // Start is called before the first frame update
    void Start()
    {
        _tranformer = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }
    /// <summary>
    /// The thought here was to replace the nav mesh with simple arrow direction movement.  
    /// Limiting the player to one title at a time until out of momment actions.
    /// </summary>
    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            _tranformer.Translate(Vector3.right * Time.deltaTime * speed * forwardForce);
                //(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            _tranformer.Translate(Vector3.left * Time.deltaTime * speed * forwardForce);
        }
        else if (Input.GetKey("w"))
        {
            _tranformer.Translate(Vector3.forward * Time.deltaTime * speed * forwardForce);
        }
        else if (Input.GetKey("s"))
        {
            _tranformer.Translate(Vector3.back * Time.deltaTime * speed * forwardForce);
        }

        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManagerEngine>().EndGame();
        }

    }
}
