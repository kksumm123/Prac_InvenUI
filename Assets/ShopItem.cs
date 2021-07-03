using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    //�Է¹������ ������, ������ ������
    public void Init(ItemDataInfo item)
    {
        transform.name = item.name;
        GetComponentInChildren<Image>().sprite = item.icon;
        GetComponentInChildren<Text>().text = item.buyPrice.ToString();
    }
}
