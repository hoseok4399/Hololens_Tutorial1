using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecuve : MonoBehaviour
{
    Vector3 a = new Vector3(0,0,0);  

    void Start()
    {
        
    }

    void Update()
    {
    a = a +  new Vector3(0,30*Time.deltaTime,0);
    transform.rotation = Quaternion.Euler(new Vector3(0,50,0)+ a); 
    
    //1. 큐브의 각도를 z축으로 50도 만큼 회전시키려면 어떻게 해야할까?
    
    //2. 1초에 10도씩 더 돌아가게 하려면 어떻게 해야할까?
    
    }

    
}
