using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Milkcocoa;

public class HistoryPanel : MonoBehaviour
{   
    MilkcocoaClient milkcocoa;
    string history = string.Empty;
    Text destination;

    // イベント
    // Use this for initialization
    void Start()
    {
        milkcocoa = FindObjectOfType<MilkcocoaClient>();
        this.destination = GameObject.Find("Canvas/HistoryPanel/History").GetComponent<Text>();
        milkcocoa.OnSend(milkcocoaEventHandler);

        this.destination.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        this.destination.text = this.history;
    }

    // メソッド
	public void milkcocoaEventHandler(MilkcocoaEvent e)
	{
        // Debug.Log("receivedJSON");
        if(e.data.GetField("params").HasField("chat"))
        {
            // Debug.Log("proper syntax");
            //受け取ったJSONファイルを読み込む
            string speakerName = e.data.GetField("params").GetField("chat").GetField("speakerName").str;
            string message = e.data.GetField("params").GetField("chat").GetField("message").str;

            // Debug.Log(string.Format("{0} : {1}", speakerName, message));
            this.history = history + Uri.UnescapeDataString(speakerName) + " : " + Uri.UnescapeDataString(message) + System.Environment.NewLine;
        }
    }
}