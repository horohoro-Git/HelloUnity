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
        //ť���� ��ġ�� ���
        //Ŭ������ ���� �ν��Ͻ�
        //CubeControllerŬ������ �ν��Ͻ�
        
        //CubeController ������Ʈ�� �پ��ִ�
        //���ӿ�����Ʈ�� transform ������Ʈ�� 
        //position �Ӽ��� ���� ���
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
