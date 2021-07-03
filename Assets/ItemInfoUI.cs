using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoUI : MonoBehaviour
{
    // Shop, Iven에서 Item이 클릭되면 표시해줘야함
    public static ItemInfoUI instance;
    public ItemDataInfo itemDataInfo; // 상점에 있는 아이템을 구매할 때 사용
    public InvenItemInfo invenItemInfo; // 인벤에 있는 아이템을 판매할 때 사용

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
        shopBtn.transform.Find("Button")
            .GetComponent<Button>().onClick.AddListener(ItemBuy);
        invenBtn.transform.Find("Button")
            .GetComponent<Button>().onClick.AddListener(ItemSell);
        shopBtn.SetActive(false);
        invenBtn.SetActive(false);
    }

    void ItemBuy()
    {
        UserData.instance.Gold -= itemDataInfo.sellPrice;
        var newItem = new InvenItemInfo();
        newItem.ItemID = itemDataInfo.ItemID;
        newItem.count = 1;
        newItem.getData = DateTime.Now.ToString();
        UserData.instance.invenItems.Add(newItem);
        InvenUI.instance.RefreshUI();
        MoneyUI.instance.RefreshUI();
    }
    void ItemSell()
    {
        Debug.Log("팔기");
    }


    public void ShowShopItemInfo(ItemDataInfo itemDataInfo)
    {
        shopBtn.SetActive(true);
        invenBtn.SetActive(false);
        SetItemInfo(itemDataInfo);
    }
    public void ShowInvenItem(InvenItemInfo invenItemInfo)
    {
        this.invenItemInfo = invenItemInfo;
        invenBtn.SetActive(true);
        shopBtn.SetActive(false);

        var itemDataInfo = invenItemInfo.GetItemDataInfo();
        SetItemInfo(itemDataInfo);
    }

    void SetItemInfo(ItemDataInfo itemDataInfo)
    {
        icon.sprite = itemDataInfo.icon;
        itemName.text = itemDataInfo.name;
        desciption.text = itemDataInfo.description;
    }
}
