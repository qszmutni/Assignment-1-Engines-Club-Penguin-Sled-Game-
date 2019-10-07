using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gametolevel : MonoBehaviour
{ 
    Vector3 defaultPos;
    Vector3 defaultRot;
    Vector3 playerpos;
    PhysicMaterial saved;
    //Camera GetCamera;
    bool levelEditor = false;

    private static gametolevel privateinstance;

    public static gametolevel publicinstance
    {
        get
        {
            if (privateinstance == null)
            {
                privateinstance = (new GameObject("container").AddComponent<gametolevel>());
                

            }


            return privateinstance;
        }
      }

    // Start is called before the first frame update
    void Start()
    {
        playerpos = GameObject.FindWithTag("Player").transform.position;
        defaultPos = Camera.main.transform.position;
        defaultRot = new Vector3(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, Camera.main.transform.rotation.eulerAngles.z);
        saved = GameObject.FindWithTag("Player").GetComponent<BoxCollider>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
             GameObject.FindWithTag("Player").GetComponent<Movement>().enabled = false;
            GameObject.FindWithTag("Player").GetComponent<BoxCollider>().material = null;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
            Camera.main.GetComponent<cameraFollow>().enabled = false;
            levelEditor = true;
            
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject.FindWithTag("Player").GetComponent<Movement>().enabled = true;
            GameObject.FindWithTag("Player").GetComponent<BoxCollider>().material = saved;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody>().useGravity = true;
            GameObject.FindWithTag("Player").transform.position = playerpos;
            Camera.main.transform.position = defaultPos;
            Camera.main.transform.rotation.eulerAngles.Set(defaultRot.x, defaultRot.y, defaultRot.z);
            Camera.main.GetComponent<cameraFollow>().enabled = true;
            levelEditor = false;
        }

    }

    public bool levelEdit()
    {
        return levelEditor;
    }
}
