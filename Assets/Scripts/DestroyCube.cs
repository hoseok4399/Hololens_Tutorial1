using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
     //1. 바로제거
     //Destroy(this.gameObject);
     //2. 5초 뒤에 제거
     Destroy(this.gameObject,5);
    }

    void Update()
    {
    {
        
    }
        
    }
}

