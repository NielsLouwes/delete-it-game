using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour
{

   public Transform player;
   public float detectionDistance = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player position , position of our game object
        float distance = Vector3.Distance(player.position, transform.position);
        
        if (distance < detectionDistance) {
             Debug.Log("Player is within range!");
        } else {
            Debug.Log("Player is out of range!");
        }
    }
}
