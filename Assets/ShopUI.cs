using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // ItemDataManager의 ItemDataList 내용 가져와서 Shop내에 진열시켜줘야함
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
        Debug.Assert(itemBase != null, "itembase 탐색 실패");
        foreach (var item in ItemDataManager.instance.itemDataList)
        {
            var newItem = Instantiate(itemBase, itemBase.transform.parent);
            newItem.Init(item);
        }
        itemBase.gameObject.SetActive(false);
    }
}
