using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gametolevel : MonoBehaviour
{
    Vector3 defaultPos;
    Vector3 defaultRot;
    public GameObject penguin;
    public Camera GetCamera;
    public static bool levelEditor = false;
    // Start is called before the first frame update
    void Start()
    {
        defaultPos = GetCamera.transform.position;
        defaultRot = new Vector3(GetCamera.transform.rotation.eulerAngles.x, GetCamera.transform.rotation.eulerAngles.y, GetCamera.transform.rotation.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            penguin.GetComponent<Movement>().enabled = false;
            penguin.GetComponent<BoxCollider>().material.dynamicFriction = 1.0f;
            GetCamera.GetComponent<cameraFollow>().enabled = false;
            levelEditor = true;
            
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            penguin.GetComponent<Movement>().enabled = true;
            penguin.GetComponent<BoxCollider>().material.dynamicFriction = 0.1f;
            GetCamera.GetComponent<cameraFollow>().enabled = true;
            GetCamera.transform.position = defaultPos;
            GetCamera.transform.rotation.eulerAngles.Set(defaultRot.x, defaultRot.y, defaultRot.z);
            levelEditor = false;
        }

        
    }
}
