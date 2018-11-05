﻿using UnityEngine;
using System.Collections;
using PureMVC.Patterns.Proxy;
using PureMVC.Interfaces;

public class LoginProxy : Proxy, IProxy
{
    public const string NAME = "LoginProxy";
    // Use this for initialization
    public LoginProxy() : base(NAME) { }
    //请求登陆
    public void sendLogin(object data)
    {
        //与服务器通讯，返回消息处理玩之后，如果需要改变试图则调用下面消息
        receiveLogin(data);
    }
    // 登陆返回
    private void receiveLogin(object data)
    {
        SendNotification(NotifyConst.R_LOGIN, data, null);
    }
}