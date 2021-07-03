using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoUI : MonoBehaviour
{
    // Shop, Iven���� Item�� Ŭ���Ǹ� ǥ���������
    public static ItemInfoUI instance;
    public ItemDataInfo itemDataInfo; // ������ �ִ� �������� ������ �� ���
    public InvenItemInfo invenItemInfo; // �κ��� �ִ� �������� �Ǹ��� �� ���

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
        Debug.Log("�ȱ�");
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
