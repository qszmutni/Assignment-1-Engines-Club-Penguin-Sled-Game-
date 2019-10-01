using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody penguin;
    public float speed = 2.0f;
    public static float force = 1.5f;
    Vector3 vec3;



    // Start is called before the first frame update
    void Start()
    {
        penguin = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vec3 = transform.position;

        float translationX = Input.GetAxis("Vertical");
        float translationY = Input.GetAxis("Horizontal");
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            vec3 = new Vector3(transform.position.x + 1.0f, vec3.y, vec3.z);
            transform.position = vec3;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            vec3 = new Vector3(transform.position.x - 1.0f, vec3.y, vec3.z);
            transform.position = vec3;
        }

        penguin.AddForce(0.0f, 0.0f, force, ForceMode.Force);


    }
}
