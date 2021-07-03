using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InvenItem : MonoBehaviour, IPointerClickHandler
{
    InvenItemInfo invenItemInfo;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            ItemInfoUI.instance.ShowInvenItem(invenItemInfo);
    }
    public void Init(InvenItemInfo item)
    {
        invenItemInfo = item;
        ItemDataInfo itemDataInfo = invenItemInfo.GetItemDataInfo();
        GetComponentInChildren<Image>().sprite = itemDataInfo.icon;
        GetComponentInChildren<Text>().text = item.count.ToString();
    }
}
