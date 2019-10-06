using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class mouseHovor : MonoBehaviour
{

    Vector4 defaultColor;
    Vector4 newColor;
    bool mouseOver = false;
    bool switchBool = false;
    bool checkPress = false;
    public GameObject mousedOver;


    Stack<GameObject> undoStack = new Stack<GameObject>();
    Stack<GameObject> redoStack = new Stack<GameObject>();

    public static GameObject currentObject;


    const string DLL_NAME = "Assignment 1 DLL";

    [DllImport(DLL_NAME)]
    private static extern void InputDLL(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern void Undo();

    [DllImport(DLL_NAME)]
    private static extern void Redo();

    [DllImport(DLL_NAME)]
    private static extern void History();

    [DllImport(DLL_NAME)]
    private static extern float X();

    [DllImport(DLL_NAME)]
    private static extern float Y();

    [DllImport(DLL_NAME)]
    private static extern float Z();

    void Awake()
    {
        defaultColor = GetComponent<Renderer>().material.GetVector("_Color2");
        newColor = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

        currentObject = mousedOver;
    }

    void Update()
    {
        if (mouseOver == true && gametolevel.publicinstance.levelEdit() == true)
        {

            mousedOver.GetComponent<Renderer>().material.SetVector("_Color2", newColor);
            if (Input.GetKeyDown(KeyCode.E) && checkPress == false)
            {

                switchBool = true;
                checkPress = true;
                undoStack.Push(mousedOver);
            }
            else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
            {
                switchBool = false;
                checkPress = false;

                InputDLL(mousedOver.transform.position.x, mousedOver.transform.position.y, mousedOver.transform.position.z);

            }

        }
        else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
        {
            switchBool = false;
            checkPress = false;

            InputDLL(mousedOver.transform.position.x, mousedOver.transform.position.y, mousedOver.transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Undo();
            redoStack.Push(undoStack.Peek());
            undoStack.Pop();
            undoStack.Peek().transform.position = new Vector3(X(), Y(), Z());
           
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            Redo();
            undoStack.Push(redoStack.Peek());
            redoStack.Pop();
            redoStack.Peek().transform.position = new Vector3(X(), Y(), Z());
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
