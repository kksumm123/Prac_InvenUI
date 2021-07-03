using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    // 아이템 목록을 그려주면 된다
    // list 변수 하나 만들기 (UserData에 만듬)
    public static InvenUI instanse;
    private void Awake()
    {
        instanse = this;
    }
    [SerializeField] InvenItem itemBase;
    void Start()
    {
        RefreshUI();
    }

    List<GameObject> childitemlist = new List<GameObject>();
    public void RefreshUI()
    {
        childitemlist.ForEach(x => Destroy(x));
        childitemlist.Clear();

        itemBase = (InvenItem)FindObjectOfType(typeof(InvenItem), true);
        itemBase.gameObject.SetActive(true);
        Debug.Assert(itemBase != null, "itembase 탐색 실패");
        foreach (var item in UserData.instance.invenItems)
        {
            var newItem = Instantiate(itemBase, itemBase.transform.parent);
            newItem.Init(item);
        }
        itemBase.gameObject.SetActive(false);
    }
}
