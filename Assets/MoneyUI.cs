using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    // ���� ��ȭ������ �����;���
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
