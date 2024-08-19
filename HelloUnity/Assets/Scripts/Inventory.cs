using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGOs;
    public GameObject itemGo; //GameObject
    private void Awake()
    {
        //itemGos를 순회 하면서 아이템들의 이름을 출력


        //장검
        //단검
        //활

        for(int i=0; i<itemGOs.Count; i++)
        {
            Item item = itemGOs[i].GetComponent<Item>();
            Debug.Log($"<color=green>{item.itemName}</color>");
        }
    }
}
