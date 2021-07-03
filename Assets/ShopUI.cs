using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // ItemDataManager�� ItemDataList ���� �����ͼ� Shop���� �������������
    ShopItem itemBase;
    private void Start()
    {
        ShopItemUpdate();
    }
    void ShopItemUpdate()
    {
        //itemBaseTr = transform.Find("Viewport/Content/ItemBase");
        itemBase = (ShopItem)FindObjectOfType(typeof(ShopItem), true);
        itemBase.gameObject.SetActive(true);
        Debug.Assert(itemBase != null, "itembase Ž�� ����");
        foreach (var item in ItemDataManager.instance.itemDataList)
        {
            var newItem = Instantiate(itemBase, itemBase.transform.parent);
            newItem.Init(item);
        }
        itemBase.gameObject.SetActive(false);
    }
}
