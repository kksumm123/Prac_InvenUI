using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    // ������ ����� �׷��ָ� �ȴ�
    // list ���� �ϳ� ����� (UserData�� ����)
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
        Debug.Assert(itemBase != null, "itembase Ž�� ����");
        foreach (var item in UserData.instance.invenItems)
        {
            var newItem = Instantiate(itemBase, itemBase.transform.parent);
            newItem.Init(item);
        }
        itemBase.gameObject.SetActive(false);
    }
}
