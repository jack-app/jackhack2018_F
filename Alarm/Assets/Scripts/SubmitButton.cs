using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Milkcocoa;

public class SubmitButton : MonoBehaviour
{
	private MilkcocoaClient milkcocoa;
	GameObject nameInputField;
	GameObject MessageInputField;


	// イベント
	// Use this for initialization
    void Start()
    {
        milkcocoa = FindObjectOfType<MilkcocoaClient>();
		this.nameInputField = GameObject.Find("NameInputField");
		this.nameInputField = GameObject.Find("MessageInputField");
    }

	// update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
    }


    // メソッド
    private JSONObject composeMsgJSON(string str)
    {
        JSONObject jsonobj = new JSONObject((JSONObject values) =>
        {
            values.AddField("chat", (JSONObject chat) =>
            {
				chat.AddField("name", Uri.EscapeDataString(userName));
				chat.AddField("messsage")//途中
            });
        });
        return jsonobj;
    }
}
