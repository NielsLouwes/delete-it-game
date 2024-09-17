using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishLogic : MonoBehaviour
{
    public Transform player;
    public PCScript pcScript; // reference our PCScript that holds the emailDeeted bool

    // Start is called before the first frame update
    void Start()
    {
        if (pcScript == null) {
            pcScript = FindAnyObjectByType<PCScript>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.position , transform.position);
       
       if (distance < 5f && pcScript.emailDeleted) {
            Debug.Log("Game over!!");
       }
    }
}
