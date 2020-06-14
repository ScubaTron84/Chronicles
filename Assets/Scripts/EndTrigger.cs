using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerEngine gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();   
    }
}
