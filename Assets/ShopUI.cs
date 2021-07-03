using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // ItemDataManager의 ItemDataList 내용 가져와서 Shop내에 진열시켜줘야함
    GameObject itemBaseGo;
    private void Start()
    {
        ShopItemUpdate();
    }
    void ShopItemUpdate()
    {
        //itemBaseTr = transform.Find("Viewport/Content/ItemBase");
        itemBaseGo = (GameObject)FindObjectOfType(typeof(ShopItem), true);

        Debug.Assert(itemBaseGo != null, "itembase 탐색 실패");
        foreach (var item in ItemDataManager.instance.itemDataList)
        {
            var newItem = Instantiate(itemBaseGo, itemBaseGo.transform.parent);
            newItem.
        }
    }
}
