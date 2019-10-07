using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionFast : MonoBehaviour
{
    public GameObject penguin;
   // public double speed = 2.0;
    float x;
    float fric = 0.7f;
    bool checkCol = false;

    // Start is called before the first frame update
    void Start()
    {
        x = penguin.transform.rotation.eulerAngles.x;
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject == penguin)
        {
            penguin.GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, Movement.force + 10, ForceMode.Acceleration);
        }
    }

}
