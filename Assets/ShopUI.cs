using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // ItemDataManager�� ItemDataList ���� �����ͼ� Shop���� �������������
    GameObject itemBaseGo;
    private void Start()
    {
        ShopItemUpdate();
    }
    void ShopItemUpdate()
    {
        //itemBaseTr = transform.Find("Viewport/Content/ItemBase");
        itemBaseGo = (GameObject)FindObjectOfType(typeof(ShopItem), true);

        Debug.Assert(itemBaseGo != null, "itembase Ž�� ����");
        foreach (var item in ItemDataManager.instance.itemDataList)
        {
            var newItem = Instantiate(itemBaseGo, itemBaseGo.transform.parent);
            newItem.
        }
    }
}
