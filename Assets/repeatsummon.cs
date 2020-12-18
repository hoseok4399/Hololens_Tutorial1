using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatsummon : MonoBehaviour
{
    float timer = 0;
    Vector3 start_position;  
    
    void Start()
    {
    //#0. 물체가 자유낙하하게 만들려면 어떻게 해야할까?

    //#1.처음 시작할 때의 물체의 위치를 start_position에 저장하시오.
       start_position = this.gameObject.transform.position;
    
    //#1-2. 처음 시작할 때의 물체의 위치보다 0.3m 높은 위치에 지정하려면 어떻게 해야할까?
    // start_position = this.gameObject.transform.position + new Vector3(0f,0.3f,0f);
    
    }

    void Update()
    {
        timer += Time.deltaTime;
        //#2. 2초가 지났을 때 떨어지는 물체가 저장해 둔 start_position으로 이동하려면 어떻게 해야할까?
        move_startposition();

        //#3. 속도가 줄지 않는데 이 속도를 0으로 초기화하는 방법은 뭘까?


    }

    void move_startposition() 
    {
        if (timer >= 2)
        {
            transform.position = start_position;
            speedreset();
            timer = 0;
        }
    }

    void speedreset()
    {
        Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
