using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    // 유저의 재화(gold, dia), 아이템 저장해줘야함
    public static UserData instance;
    private void Awake()
    {
        instance = this;
    }

}
