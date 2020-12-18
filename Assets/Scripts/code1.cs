using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code1 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    
    void makerigidbody()
    {
        var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    void destroycube()
    {
        GameObject a = GameObject.Find("Cube2");
        Destroy(a);
    }

    
    void startInvoke()
    {
        InvokeRepeating("spawn",0f,3f);
    }

    void spawn()
    {
        Vector3 position = new Vector3(Random.Range(-1f, 1f), Random.Range(1f, 1f), Random.Range(-2f, 2f));
        Instantiate(target, position, Quaternion.Euler(0,0,0));
    }
    
}
