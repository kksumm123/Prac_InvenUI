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
    }

}
