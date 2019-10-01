using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject penguin;
    //public Rigidbody penguinHitbox;
    float x;
    float fric = 0.7f;
    bool checkCol = false;

    // Start is called before the first frame update
    void Start()
    {
        x = penguin.transform.rotation.eulerAngles.x;
    }

    private void OnTriggerEnter(Collider Other){
        if (Other.gameObject == penguin) {
            StartCoroutine(waitTime());
        }
    }

    IEnumerator waitTime()
    {
        checkCol = true;
       // penguin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
        penguin.GetComponent<BoxCollider>().material.dynamicFriction = fric;
        yield return new WaitForSeconds(2);
       // penguin.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        penguin.GetComponent<BoxCollider>().material.dynamicFriction = 0.1f;


        // print(Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        if (checkCol == true)
        {
            fric++;
        }
    }
}
