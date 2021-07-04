using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    // 아이템 목록을 그려주면 된다
    // list 변수 하나 만들기 (UserData에 만듬)
    public static InvenUI instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] InvenItem itemBase;
    void Start()
    {
        itemBase = (InvenItem)FindObjectOfType(typeof(InvenItem), true);
        RefreshUI();
    }

    List<GameObject> childitemlist = new List<GameObject>();
    public void RefreshUI()
    {
        childitemlist.ForEach(x => Destroy(x));
        childitemlist.Clear();

        itemBase.gameObject.SetActive(true);
        Debug.Assert(itemBase != null, "itembase 탐색 실패");
        InvenItem newItem;
        foreach (var item in UserData.instance.invenItems)
        {
            newItem = Instantiate(itemBase, itemBase.transform.parent);
            newItem.Init(item);
            childitemlist.Add(newItem.gameObject);
        }
        itemBase.gameObject.SetActive(false);
    }
}
