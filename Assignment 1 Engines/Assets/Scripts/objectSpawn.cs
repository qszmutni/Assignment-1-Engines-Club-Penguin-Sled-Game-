using System.Collections;
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


        if (Input.GetKeyDown(KeyCode.Alpha2) && gametolevel.levelEditor == true)
        {
            _obj.GetObject("Log");

        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && gametolevel.levelEditor == true)
        {
            _obj.GetObject("Stump");

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
            return currentObject;
        }
    }


}

