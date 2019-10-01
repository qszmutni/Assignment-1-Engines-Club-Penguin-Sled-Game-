using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraFollow : MonoBehaviour
{

    public GameObject penguin;

    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - penguin.transform.position;
        
    }

  // Called after each frame.
    void LateUpdate()
    {
        transform.position = penguin.transform.position + distance;
        
    }
}
