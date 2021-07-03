using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    // 현재 재화정보를 가져와야함
    public static MoneyUI instance;
    Text goldText;
    Text diaText;
    private void Awake()
    {
        instance = this;
        goldText = transform.Find("Gold/Value").GetComponent<Text>();
        diaText = transform.Find("Dia/Value").GetComponent<Text>();
    }
    private void Start()
    {
        RefreshUI();
    }

    public void RefreshUI()
    {
        goldText.text = UserData.instance.Gold.ToString();
        diaText.text = UserData.instance.Dia.ToString();
    }
}
