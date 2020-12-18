using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliderevent : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      DeleteSphere();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Destroy()
    {
      //Destroy(this.gameObject);
    }
    
    
    void DeleteSphere()
    {
      //GameObject a = GameObject.Find("sphere_1");
      //GameObject a = GameObject.FindWithTag("ddd");
      //Destroy(a);
    }
    
    }



