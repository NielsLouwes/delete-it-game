using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JanitorScript : MonoBehaviour
{
    public float janitorSpeed = 7f;
    public Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move towards ppalyer transfform position at velocity
        Vector3 displacementFromTarget = playerTransform.position - transform.position;
        Vector3 directionToTarget= displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * janitorSpeed;

        float distanceToTarget = displacementFromTarget.magnitude;

        if (distanceToTarget > 1.5f) {
                transform.Translate (velocity * Time.deltaTime);
        }

    }
}
