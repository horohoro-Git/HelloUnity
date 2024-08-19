using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private void Awake()
    {
        
    }



    // Start is called before the first frame update
    void Start()
    {
        //큐브의 위치를 출력
        //클래스의 현재 인스턴스
        //CubeController클래스의 인스턴스
        
        //CubeController 컴포넌트가 붙어있는
        //게임오브젝트의 transform 컴포넌트의 
        //position 속성의 값을 출력
       /* Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);

        transform.position = new Vector3(0, 0, 0);*/
        //transform.position = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.gameObject.GetComponent<Transform>();
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);
        transform.position += new Vector3(0, 0, 0.01f);
    }
}
