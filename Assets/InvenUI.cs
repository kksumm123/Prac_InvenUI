using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    // ������ ����� �׷��ָ� �ȴ�
    // list ���� �ϳ� ����� (UserData�� ����)
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
        Debug.Assert(itemBase != null, "itembase Ž�� ����");
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
