﻿
//*********************❤*********************
// 
// 文件名（File Name）：	DealWithUDPMessage.cs
// 
// 作者（Author）：			LoveNeon
// 
// 创建时间（CreateTime）：	Don't Care
// 
// 说明（Description）：	接受到消息之后会传给我，然后我进行处理
// 
//*********************❤*********************

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Linq;

public class DealWithUDPMessage : MonoBehaviour {



    public static DealWithUDPMessage instance;
    // public GameObject wellMesh;
    private string dataTest;
    // public static char[] sliceStr;



    /// <summary>
    /// 消息处理
    /// </summary>
    /// <param name="_data"></param>
    public void MessageManage(string _data)
    {
        if (_data != "")
        {


            dataTest = _data;

            Debug.Log(dataTest);

         

            if (dataTest == "2002")//
            {
                EventCenter.Broadcast(EventDefine.PlayAnimation);
                SendUPDData.instance.udp_Send(dataTest, "192.168.1.52", 29010);

            }
            if (dataTest == "2003") {//重置
                ResetNode();
                SendUPDData.instance.udp_Send(dataTest, "192.168.1.52", 29010);
                //EventCenter.Broadcast(EventDefine.StopAnimation);
            }

            if (ValueSheet.udp_Action.ContainsKey(dataTest)) {
                ValueSheet.udp_Action[dataTest].Invoke();
            }

        }

    }

    public void ResetNode() {
        foreach (var item in ValueSheet.bannerCtrs)
        {
            item.toDefaultPos();
        }
        this.GetComponent<Animator>().SetBool("Idle", true);
    }


    private void Awake()
    {

    }

    public IEnumerator Initialization() {
        if (instance == null)
        {
            instance = this;
        }
        yield return new  WaitForSeconds(0.01f);
    }

    public void Start()
    {
        EventCenter.AddListener(EventDefine.PlayAnimation, TriggerAnim);
    }

    public void TriggerAnim() {
        this.GetComponent<Animator>().SetBool("Idle",false);
        this.GetComponent<Animator>().SetTrigger("Play");
    }

    private void Update()
    {


        //Debug.Log("数据：" + dataTest);  
    }

  

}
