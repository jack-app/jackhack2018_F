using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class AlarmScript : MonoBehaviour {

    private int Getuptime;
    private bool still_touth;
    private bool today_getup;
    private bool still_run;
    public AudioClip Audio;
    private int now;
	// Use this for initialization
	void Start () {
        still_touth = false;
        still_run = false;
        string getup = "--:--";

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

        fileMon.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Monday")
            getup = ReaderMon.ReadString();

        fileThu.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Tuesday")
            getup = ReaderThu.ReadString();

        fileWed.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Wednesday")
            getup = ReaderWed.ReadString();

        fileThe.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Thursday")
            getup = ReaderThe.ReadString();

        fileFri.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Friday")
            getup = ReaderFri.ReadString();

        fileSat.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Saturday")
            getup = ReaderSat.ReadString();

        fileSun.Seek(0, SeekOrigin.Begin);
        if("" + System.DateTime.Now.DayOfWeek == "Sunday")
            getup = ReaderSun.ReadString();

        if(getup[0] == '-' || getup[3] == '-')
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
        if(now < 5)
        {
            still_touth = false;
            still_run = false;
        }
        now = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
        if (still_touth == false && today_getup == true && now >= Getuptime && still_run == false) {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(Audio);
            still_run = true;
        }

        if(Input.GetAxisRaw("Submit") != 0)
        {
            still_touth = true;
            //ここにシーン切り替え・起きたメッセージを送るのを書く
        }
        /*ここにメッセージが送られた条件を書くと音なる。 if(){
           AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(Audio);
         }*/
    }
}
