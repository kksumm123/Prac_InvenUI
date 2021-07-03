using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoUI : MonoBehaviour
{
    // Shop, Iven에서 Item이 클릭되면 표시해줘야함
    public static ItemInfoUI instance;
    private void Awake()
    {
        instance = this;
    }

    Image icon;
    Text itemName;
    Text desciption;
    GameObject shopBtn;
    GameObject invenBtn;

    private void Start()
    {
        icon = transform.Find("Icon").GetComponent<Image>();
        itemName = transform.Find("ItemName").GetComponent<Text>();
        desciption = transform.Find("Description").GetComponent<Text>();
        shopBtn = transform.Find("ShopBtn").gameObject;
        invenBtn = transform.Find("InvenBtn").gameObject;
        shopBtn.SetActive(false);
        invenBtn.SetActive(false);
    }

    public void ShowShopItemInfo(ItemDataInfo itemDataInfo)
    {
        shopBtn.SetActive(true);
        invenBtn.SetActive(false);
        SetItemInfo(itemDataInfo);
    }

    void SetItemInfo(ItemDataInfo itemDataInfo)
    {
        icon.sprite = itemDataInfo.icon;
        itemName.text = itemDataInfo.name;
        desciption.text = itemDataInfo.description;
    }
}
