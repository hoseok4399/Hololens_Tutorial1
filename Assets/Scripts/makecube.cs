using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makecube : MonoBehaviour
{
    public GameObject target;
    
    void Start()
    {
    //1.생성(대상, 생성위치, 생성될 때 각도)
    
    //2. 나로 부터 앞으로1m, 위로 30cm 있는 위치에 큐브 1개를 만드려면 어떻게 해야할까?
    //Instantiate(target, new Vector3(0f,0.3f,1f), Quaternion.Euler(10f,10f,30f));

    //3. startInvoke() 함수를 실행 시켜 보시오, 3초마다 생성
    
    //4. 0.2초마다 생겨나게 해보면 어떨까?

    }

    void Update()
    {
        
    }

    void startInvoke()
    {
        InvokeRepeating("spawn",0f,0.1f);
    }

    void spawn()
    {
        Vector3 position = new Vector3(Random.Range(-1f, 1f), Random.Range(0.5f, 1f), Random.Range(1.2f, 3f));
        Instantiate(target, position, Quaternion.Euler(0,0,0));
    }

    
}
