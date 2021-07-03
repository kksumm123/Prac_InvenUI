using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    Etc,
}
[System.Serializable]
public class ItemDataInfo
{
    // Name, ItemID, Type, Icon, Description, BuyPrice, SellPrice
    public string name;
    public int ItemID;
    public ItemType type;
    public Sprite icon;
    public string description;
    public int buyPrice;
    public int sellPrice;
}
public class ItemDataManager : MonoBehaviour
{
    public List<ItemDataInfo> itemDataList = new List<ItemDataInfo>();
    public static ItemDataManager instance;
    private void Awake()
    {
        instance = this;
    }
}
