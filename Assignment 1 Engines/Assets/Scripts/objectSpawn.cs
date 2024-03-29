﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawn : MonoBehaviour
{

    typeOfObject _obj;
    void Start()
    {
         _obj = new typeOfObject();

    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha2) && gametolevel.publicinstance.levelEdit() == true)
        {
            _obj.GetObject("Log");

        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && gametolevel.publicinstance.levelEdit() == true)
        {
            _obj.GetObject("Stump");

        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && gametolevel.publicinstance.levelEdit() == true)
        {
            _obj.GetObject("Ice");

        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && gametolevel.publicinstance.levelEdit() == true)
        {
            _obj.GetObject("Slope");

        }


    }

    public abstract class objectSpawner
    {
        public abstract Vector3 position();
        public abstract Vector3 rotation();
        public abstract Vector3 scale();
        public abstract string tag();

    }

    public class log : objectSpawner
    { 

      public log()
        {
            Instantiate(GameObject.FindWithTag(this.tag()), this.position(), Quaternion.Euler(this.rotation()));
        }

        public override Vector3 position()
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }


        public override Vector3 rotation()
        {
            return GameObject.FindWithTag(this.tag()).transform.rotation.eulerAngles;
        }


        public override Vector3 scale()
        {
            return GameObject.FindWithTag(this.tag()).transform.localScale;
        }


        public override string tag()
        {
            return "Log";
        }
    }

    public class stump : objectSpawner
    {

        public stump ()
        {
            Instantiate(GameObject.FindWithTag(this.tag()), this.position(), Quaternion.Euler(this.rotation()));
        }

        public override Vector3 position()
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }


        public override Vector3 rotation()
        {
            return GameObject.FindWithTag(this.tag()).transform.rotation.eulerAngles;
        }


        public override Vector3 scale()
        {
            return GameObject.FindWithTag(this.tag()).transform.localScale;
        }

        public override string tag()
        {
            return "Stump";
        }
    }

    public class ice : objectSpawner
    {

        public ice()
        {
            Instantiate(GameObject.FindWithTag(this.tag()), this.position(), Quaternion.Euler(this.rotation()));
        }

        public override Vector3 position()
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }


        public override Vector3 rotation()
        {
            return GameObject.FindWithTag(this.tag()).transform.rotation.eulerAngles;
        }


        public override Vector3 scale()
        {
            return GameObject.FindWithTag(this.tag()).transform.localScale;
        }

        public override string tag()
        {
            return "Ice";
        }
    }

    public class slope : objectSpawner
    {

        public  slope()
        {
            Instantiate(GameObject.FindWithTag(this.tag()), this.position(), Quaternion.Euler(this.rotation()));
        }

        public override Vector3 position()
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }


        public override Vector3 rotation()
        {
            return GameObject.FindWithTag(this.tag()).transform.rotation.eulerAngles;
        }


        public override Vector3 scale()
        {
            return GameObject.FindWithTag(this.tag()).transform.localScale;
        }

        public override string tag()
        {
            return "Slope";
        }
    }

    public abstract class factoryOBJ
    {
        protected abstract objectSpawner makeObjSpawn(string tag);


        public objectSpawner GetObject(string tag)
        {
            objectSpawner currentObject = makeObjSpawn(tag);

            currentObject.position();
            currentObject.rotation();
            currentObject.scale();
            currentObject.tag();

            return currentObject;
        }  
        
    }

    public class typeOfObject : factoryOBJ
    {
        protected override objectSpawner makeObjSpawn(string tag)
        {
            objectSpawner currentObject = null;

            if (tag == "Log")
            {
                return new log();
            }

            if (tag == "Stump")
            {
                return new stump();
            }


            if (tag == "Ice")
            {
                return new ice();
            }


            if (tag == "Slope")
            {
                return new slope();
            }
            return currentObject;
        }
    }


}

