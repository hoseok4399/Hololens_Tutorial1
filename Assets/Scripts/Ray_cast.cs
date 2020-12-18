using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_cast : MonoBehaviour
{
    public GameObject FocusedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {
        GameObject oldFocusObject = FocusedObject;
        RaycastHit hitInfo;
       if (Physics.Raycast(
               Camera.main.transform.position,
               Camera.main.transform.forward,
               out hitInfo))
               {
                   FocusedObject = hitInfo.collider.gameObject;
               }
               else
               {
                   FocusedObject=null;
               }

        if(!hitInfo.transform.GetComponent<Rigidbody>())
        {
            var rigidbody = hitInfo.collider.gameObject.AddComponent<Rigidbody>();
        }
        }

    }
}
