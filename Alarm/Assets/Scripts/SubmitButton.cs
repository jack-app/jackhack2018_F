using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Milkcocoa;

public class SubmitButton : MonoBehaviour
{
	private MilkcocoaClient milkcocoa;


	// イベント
	// Use this for initialization
    void Start()
    {
        milkcocoa = FindObjectOfType<MilkcocoaClient>();
    }

	// update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        string speakerName = GameObject.Find("Canvas/NameInputField/Text").GetComponent<Text>().text ?? string.Empty;
        string message = GameObject.Find("Canvas/MessageInputField/Text").GetComponent<Text>().text ?? string.Empty;
        // Debug.Log("clicked");
        // Debug.Log(userName);
        // Debug.Log(message);
        milkcocoa.Send(createMessageJSON(speakerName, message));
    }


    // メソッド
    private JSONObject createMessageJSON(string speakerName, string message)
    {
        JSONObject jsonobj = new JSONObject((JSONObject values) =>
        {
            values.AddField("chat", (JSONObject chat) =>
            {
				chat.AddField("speakerName", Uri.EscapeDataString(speakerName));
				chat.AddField("messsage", Uri.EscapeDataString(message));
            });
        });
        Debug.Log(jsonobj);
        return jsonobj;
    }
}
