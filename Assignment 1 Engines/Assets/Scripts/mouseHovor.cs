using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 


public class mouseHovor : MonoBehaviour
{

    Vector4 defaultColor;
    Vector4 newColor;
    bool mouseOver = false;
    bool switchBool = false;
    bool checkPress = false;
    public GameObject mousedOver;

    public static GameObject currentObject;

    void Awake()
    {
        defaultColor = GetComponent<Renderer>().material.GetVector("_Color2");
        newColor = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

        currentObject = mousedOver;
    }

    void Update()
    {
        if (mouseOver == true && gametolevel.levelEditor == true)
        {

            mousedOver.GetComponent<Renderer>().material.SetVector("_Color2", newColor);
            if (Input.GetKeyDown(KeyCode.E) && checkPress == false)
            {

                switchBool = true;
                checkPress = true;
            }
            else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
            {
                switchBool = false;
                checkPress = false;

            }

        }
        else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
        {
            switchBool = false;
            checkPress = false;

        }



        if (switchBool == true)
        {
           mousedOver.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }


    void OnMouseOver()
    {
        mouseOver = true;
        //if (mouseOver == true && switchBool == false)
        //{
            //GetComponent<Renderer>().material.SetVector("_Color2", newColor);
            //switchBool = false;
        //}else{
        //    switchBool = true;
        //}

    }



    void OnMouseExit()
    {
        mouseOver = false;
        //if (mouseOver == false && switchBool == true)
        //{
            mousedOver.GetComponent<Renderer>().material.SetVector("_Color2", defaultColor);
        //    switchBool = true;
        //}else{
        //    switchBool = false;
        //}
       
    }

}
