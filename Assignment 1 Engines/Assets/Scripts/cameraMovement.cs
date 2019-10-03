using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Camera GetCamera;

    float rotY, rotX;
   
   
    // Start is called before the first frame update
    void Start()
    {

        rotY = GetCamera.transform.eulerAngles.y;
        rotX = GetCamera.transform.eulerAngles.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (gametolevel.levelEditor == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                GetCamera.transform.position = GetCamera.transform.position + (transform.forward * 10.0f * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.A))
            {
                GetCamera.transform.position = GetCamera.transform.position + (-GetCamera.transform.right * 10.0f * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.S))
            {
                GetCamera.transform.position = GetCamera.transform.position + (-GetCamera.transform.forward * 10.0f * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.D))
            {
                GetCamera.transform.position = GetCamera.transform.position + (GetCamera.transform.right * 10.0f * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.R))
            {
                GetCamera.transform.position = GetCamera.transform.position + (GetCamera.transform.up * 10.0f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.F))
            {
                GetCamera.transform.position = GetCamera.transform.position + (-GetCamera.transform.up * 10.0f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotY -= 1.0f;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rotY += 1.0f;
            }


            if (Input.GetKey(KeyCode.UpArrow))
            {
                rotX -= 1.0f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rotX += 1.0f;
            }



            GetCamera.transform.eulerAngles = new Vector3(rotX, rotY);
        }

        
    }
}
