using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        //Set start camera offset
        cameraOffset = new Vector3(0f, 1.5f, -4.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
