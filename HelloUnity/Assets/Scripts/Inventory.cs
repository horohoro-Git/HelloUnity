using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGOs;
    public GameObject itemGo; //GameObject
    private void Awake()
    {
        //itemGos�� ��ȸ �ϸ鼭 �����۵��� �̸��� ���


        //���
        //�ܰ�
        //Ȱ

        for(int i=0; i<itemGOs.Count; i++)
        {
            Item item = itemGOs[i].GetComponent<Item>();
            Debug.Log($"<color=green>{item.itemName}</color>");
        }
    }
}
