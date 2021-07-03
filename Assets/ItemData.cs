using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{ 
    Weapon,
    Armor,
    Potion,
}
public class ItemData : MonoBehaviour
{
    // Name, ItemID, Type, Icon, Description, BuyPrice, SellPrice
    public string name;
    public int ItemID;
    public ItemType type;
    public Image icon;
    public string description;
    public int buyPrice;
    public int sellPrice;
}
