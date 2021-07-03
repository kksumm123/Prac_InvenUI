using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour, IPointerClickHandler
{
    ItemDataInfo itemDataInfo;
    //�Է¹������ ������, ������ ������
    public void Init(ItemDataInfo item)
    {
        this.itemDataInfo = item;
        transform.name = item.name;
        GetComponentInChildren<Image>().sprite = item.icon;
        GetComponentInChildren<Text>().text = item.buyPrice.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ItemInfoUI.instance.ShowShopItemInfo(itemDataInfo);
    }
}
