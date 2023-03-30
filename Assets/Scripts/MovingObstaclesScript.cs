using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovingObstaclesScript : MonoBehaviour
{
    public float Speed = .2f;
    public float Strength = 1f;

    private float _randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        _randomOffset = Random.Range(0f, 2f);  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Sin(Time.time * Speed + _randomOffset) * Strength;
        transform.position = position;
    }
}
