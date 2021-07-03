using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    // ������ ��ȭ(gold, dia), ������ �����������
    public static UserData instance;
    private void Awake()
    {
        instance = this;
        Load();
    }


    int gold;
    int dia;
    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }
    public int Dia
    {
        get { return dia; }
        set { dia = value; }
    }

    void Load()
    {
        Gold = HasKeyLoadInt("gold", 1000);
        Dia = HasKeyLoadInt("dia", 200);

        int HasKeyLoadInt(string key, int defaultValue)
        {
            if (PlayerPrefs.HasKey(key))
                return PlayerPrefs.GetInt(key);
            else
                return defaultValue;
        }
    }
    void Save()
    {
        PlayerPrefs.SetInt("gold", Gold);
        PlayerPrefs.SetInt("dia", Dia);
    }
}
