﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using Milkcocoa;


public class AlarmScript : MonoBehaviour {

    private int Getuptime;
    private bool still_touth;
    private bool today_getup;
    private bool still_run;
    public AudioClip Audio;
    private int now;
    public GameObject text;
    public int take_time;
    public bool Success;

    public MilkcocoaClient milkcocoa;

	// Use this for initialization
	void Start () {
        still_touth = false;
        still_run = false;
        Success = false;
        string getup = "- - :- -";

        milkcocoa = FindObjectOfType<MilkcocoaClient>();
        milkcocoa.OnSend(milkcocoaEventHandler);

        FileStream fileMon  = new FileStream("dateMon.dat", FileMode.Open, FileAccess.Read);
        FileStream fileThu = new FileStream("dateThu.dat", FileMode.Open, FileAccess.Read);
        FileStream fileWed = new FileStream("dateWed.dat", FileMode.Open, FileAccess.Read);
        FileStream fileThe = new FileStream("dateThe.dat", FileMode.Open, FileAccess.Read);
        FileStream fileFri = new FileStream("dateFri.dat", FileMode.Open, FileAccess.Read);
        FileStream fileSat = new FileStream("dateSat.dat", FileMode.Open, FileAccess.Read);
        FileStream fileSun = new FileStream("dateSun.dat", FileMode.Open, FileAccess.Read);

        BinaryReader ReaderMon = new BinaryReader(fileMon);
        BinaryReader ReaderThu = new BinaryReader(fileThu);
        BinaryReader ReaderWed = new BinaryReader(fileWed);
        BinaryReader ReaderThe = new BinaryReader(fileThe);
        BinaryReader ReaderFri = new BinaryReader(fileFri);
        BinaryReader ReaderSat = new BinaryReader(fileSat);
        BinaryReader ReaderSun = new BinaryReader(fileSun);

        if ("" + System.DateTime.Now.DayOfWeek == "Monday")
        {
            fileMon.Seek(0, SeekOrigin.Begin);
            getup = ReaderMon.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Tuesday")
        {
            fileThu.Seek(0, SeekOrigin.Begin);
            getup = ReaderThu.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Wednesday")
        {
            fileWed.Seek(0, SeekOrigin.Begin);
            getup = ReaderWed.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Thursday")
        {
            fileThe.Seek(0, SeekOrigin.Begin);
            getup = ReaderThe.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Friday")
        {
            fileFri.Seek(0, SeekOrigin.Begin);
            getup = ReaderFri.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Saturday")
        {
            fileSat.Seek(0, SeekOrigin.Begin);
            getup = ReaderSat.ReadString();
        }
        if ("" + System.DateTime.Now.DayOfWeek == "Sunday")
        {
            fileSun.Seek(0, SeekOrigin.Begin);
            getup = ReaderSun.ReadString();
        }

        if(getup[0] == '-' || getup[5] == '-')
        {
            today_getup = false;
        }
        else
        {
            today_getup = true;
            Getuptime = (getup[0] - '0') * 36000 + (getup[1] - '0') * 3600 + (getup[3] - '0') * 600 + (getup[4] - '0') * 60; 

        }

    }

    // Update is called once per frame
    void Update () {
        now = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
        if (now < 5)
        {
            still_touth = false;
            still_run = false;
            Success = false;
        }
        
        if(now > Getuptime && now < Getuptime + 300)
        {
            take_time = now - Getuptime;
        }
        if (still_touth == false && today_getup == true && now >= Getuptime && still_run == false) {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = Audio;
            audioSource.PlayOneShot(Audio);
            still_run = true;
            text.SetActive(true);
        }

        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = Audio;
            audioSource.PlayOneShot(Audio);
            still_run = true;
            text.SetActive(true);
        }

        if (still_run)
        {
            if (Input.GetAxisRaw("Submit") != 0)
            {
                SceneManager.LoadScene("Scenes/ChatRoom");
            }

        }
    }

    void milkcocoaEventHandler(MilkcocoaEvent e)
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = Audio;
        audioSource.PlayOneShot(Audio);
    }
}
