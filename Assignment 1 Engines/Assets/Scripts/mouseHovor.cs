using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class mouseHovor : MonoBehaviour
{

    Vector4 defaultColor;
    Vector4 newColor;
    Vector3 temp;
    bool mouseOver = false;
    bool switchBool = false;
    bool checkPress = false;
    string currentObject;
    public GameObject mousedOver;


    Stack<GameObject> undoStack = new Stack<GameObject>();
    Stack<GameObject> redoStack = new Stack<GameObject>();

   


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

    }

    void Update()
    {

 
        if (mouseOver == true && gametolevel.publicinstance.levelEdit() == true)
        {
           // Debug.Log("test");
            
            mousedOver.GetComponent<Renderer>().material.SetVector("_Color2", newColor);
            if (Input.GetKeyDown(KeyCode.E) && checkPress == false)
            {
                currentObject = mousedOver.name;
               Debug.Log(currentObject);
                undoStack.Push(mousedOver);
                Debug.Log(mousedOver.name);
                InputDLL(mousedOver.transform.position.x, mousedOver.transform.position.y, mousedOver.transform.position.z);
                 Debug.Log(mousedOver.transform.position);
                switchBool = true;
                checkPress = true;

            }
            else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
            {
                switchBool = false;
                undoStack.Push(mousedOver);
                InputDLL(mousedOver.transform.position.x, mousedOver.transform.position.y, mousedOver.transform.position.z);
                Debug.Log(mousedOver.transform.position);
                checkPress = false;
            }

        }
        else if (Input.GetKeyDown(KeyCode.E) && checkPress == true)
        {
            switchBool = false;
            undoStack.Push(mousedOver);
            InputDLL(mousedOver.transform.position.x, mousedOver.transform.position.y, mousedOver.transform.position.z);
            Debug.Log(mousedOver.transform.position);
            checkPress = false;
        }

        if (switchBool == true)
        {

            //Debug.Log("TRUE!");
            mousedOver.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }


        if (Input.GetKeyDown(KeyCode.C) && gametolevel.publicinstance.levelEdit() == true)
        {
            if (currentObject == mousedOver.name)
            {
                Debug.Log("undo");
                redoStack.Push(undoStack.Peek());
                undoStack.Pop();
                Undo();
                temp = new Vector3(X(), Y(), Z());
                Debug.Log(temp);
                GameObject.Find(undoStack.Peek().name).transform.position = temp;



            }
           
        }

        if (Input.GetKeyDown(KeyCode.V) && gametolevel.publicinstance.levelEdit() == true)
        {
            if (currentObject == mousedOver.name)
            {
                Debug.Log("redo");
                undoStack.Push(redoStack.Peek());
                redoStack.Pop();
                Redo();
                temp = new Vector3(X(), Y(), Z());
                Debug.Log(temp);
                GameObject.Find(redoStack.Peek().name).transform.position = temp;
            }
        }


       
    }


    void OnMouseOver()
    {
        mouseOver = true;


    }



    void OnMouseExit()
    {
        mouseOver = false;
     
            mousedOver.GetComponent<Renderer>().material.SetVector("_Color2", defaultColor);
  
       
    }

}
