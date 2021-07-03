using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour, IPointerClickHandler
{
    //입력받은대로 아이콘, 가격을 변경함
    public void Init(ItemDataInfo item)
    {
        transform.name = item.name;
        GetComponentInChildren<Image>().sprite = item.icon;
        GetComponentInChildren<Text>().text = item.buyPrice.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }
}
