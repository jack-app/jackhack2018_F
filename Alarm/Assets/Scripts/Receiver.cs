using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Milkcocoa;

public class MonoBehaviour
{   
    MilkcocoaClient milkcocoa;
    string chatHistory;
    Text destination;

    // イベント
    // Use this for initialization
    void Start()
    {
        this.milkcocoa = FindObjectOfType<MilkcocoaClient>();
        this.destination = GameObject.Find("Canvas/ChatHistoryPane/Text").GetComponent<Text>();
        milkcocoa.OnSend(milkcocoaEventHandler);

        this.destination.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // メソッド
	public void milkcocoaEventHandler(MilkcocoaEvent e)
	{
        Debug.Log("receivedJSON");
        if(e.data.GetField("params").HasField("chat"))
        {
            //受け取ったJSONファイルを読み込む
            string speakerName = e.data.GetField("params").GetField("chat").GetField("speakerName").str;
            string message = e.data.GetField("params").GetField("chat").GetField("message").str;

            this.destination.text = chatHistory + speakerName + " : " + message;
        }
    }
}