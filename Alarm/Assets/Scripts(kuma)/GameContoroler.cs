using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class GameContoroler : MonoBehaviour {
    private int n;
    private int Mon_h;
    private int Mon_m;
    private int Thu_h;
    private int Thu_m;
    private int Wed_h;
    private int Wed_m;
    private int The_h;
    private int The_m;
    private int Fri_h;
    private int Fri_m;
    private int Sat_h;
    private int Sat_m;
    private int Sun_h;
    private int Sun_m;
    public UnityEngine.UI.Text Mon;
    public UnityEngine.UI.Text Thu;
    public UnityEngine.UI.Text Wed;
    public UnityEngine.UI.Text The;
    public UnityEngine.UI.Text Fri;
    public UnityEngine.UI.Text Sat;
    public UnityEngine.UI.Text Sun;

	// Use this for initialization
	void Start () {
        Mon_h = The_h = Wed_h = Thu_h = Fri_h = Sat_h = Sun_h = 24;
        Mon_m = The_m = Wed_m = Thu_m = Fri_m = Sat_m = Sun_m = 60;
        n = 0;
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("Yabai");
        StartCoroutine("Owata");

        if (Input.GetAxisRaw("Submit") != 0)
        {
            FileStream fileMon = new FileStream("dateMon.dat", FileMode.Create, FileAccess.Write);
            FileStream fileThu = new FileStream("dateThu.dat", FileMode.Create, FileAccess.Write);
            FileStream fileWed = new FileStream("dateWed.dat", FileMode.Create, FileAccess.Write);
            FileStream fileThe = new FileStream("dateThe.dat", FileMode.Create, FileAccess.Write);
            FileStream fileFri = new FileStream("dateFri.dat", FileMode.Create, FileAccess.Write);
            FileStream fileSat = new FileStream("dateSat.dat", FileMode.Create, FileAccess.Write);
            FileStream fileSun = new FileStream("dateSun.dat", FileMode.Create, FileAccess.Write);

            BinaryWriter writerMon = new BinaryWriter(fileMon);
            BinaryWriter writerThu = new BinaryWriter(fileThu);
            BinaryWriter writerWed = new BinaryWriter(fileWed);
            BinaryWriter writerThe = new BinaryWriter(fileThe);
            BinaryWriter writerFri = new BinaryWriter(fileFri);
            BinaryWriter writerSat = new BinaryWriter(fileSat);
            BinaryWriter writerSun = new BinaryWriter(fileSun);

            writerMon.Write(Mon.text);
            writerThu.Write(Thu.text);
            writerWed.Write(Wed.text);
            writerThe.Write(The.text);
            writerFri.Write(Fri.text);
            writerSat.Write(Sat.text);
            writerSun.Write(Sun.text);

            SceneManager.LoadScene("アラーム画面");
        }

    }

    IEnumerator Owata()
    {
        if(Input.GetAxisRaw("Vertical") != 0)
        {
            switch (n) {
                case 0: if(Input.GetAxisRaw("Vertical") == 1)
                    {
                        if(Mon_h < 24)
                        {
                            Mon_h++;
                        }
                        else
                        {
                            Mon_h = 0;
                        }
                    }
                    else
                    {
                        if(Mon_h > 0)
                        {
                            Mon_h--;
                        }
                        else
                        {
                            Mon_h = 24;
                        }
                    }break;

                case 1:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Mon_m < 60)
                        {
                            Mon_m += 10;
                        }
                        else
                        {
                            Mon_m = 0;
                        }
                    }
                    else
                    {
                        if (Mon_m > 0)
                        {
                            Mon_m -= 10;
                        }
                        else
                        {
                            Mon_m = 60;
                        }
                    }
                    break;

                case 2:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Thu_h < 24)
                        {
                            Thu_h++;
                        }
                        else
                        {
                            Thu_h = 0;
                        }
                    }
                    else
                    {
                        if (Thu_h > 0)
                        {
                            Thu_h--;
                        }
                        else
                        {
                            Thu_h = 24;
                        }
                    }
                    break;

                case 3:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Thu_m < 60)
                        {
                            Thu_m += 10;
                        }
                        else
                        {
                            Thu_m = 0;
                        }
                    }
                    else
                    {
                        if (Thu_m > 0)
                        {
                            Thu_m -= 10;
                        }
                        else
                        {
                            Thu_m = 60;
                        }
                    }
                    break;

                case 4:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Wed_h < 24)
                        {
                            Wed_h++;
                        }
                        else
                        {
                            Wed_h = 0;
                        }
                    }
                    else
                    {
                        if (Wed_h > 0)
                        {
                            Wed_h--;
                        }
                        else
                        {
                            Wed_h = 24;
                        }
                    }
                    break;

                case 5:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Wed_m < 60)
                        {
                            Wed_m += 10;
                        }
                        else
                        {
                            Wed_m = 0;
                        }
                    }
                    else
                    {
                        if (Wed_m > 0)
                        {
                            Wed_m -= 10;
                        }
                        else
                        {
                            Wed_m = 60;
                        }
                    }
                    break;

                case 6:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (The_h < 24)
                        {
                            The_h++;
                        }
                        else
                        {
                            The_h = 0;
                        }
                    }
                    else
                    {
                        if (The_h > 0)
                        {
                            The_h--;
                        }
                        else
                        {
                            The_h = 24;
                        }
                    }
                    break;

                case 7:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (The_m < 60)
                        {
                            The_m += 10;
                        }
                        else
                        {
                            The_m = 0;
                        }
                    }
                    else
                    {
                        if (The_m > 0)
                        {
                            The_m -= 10;
                        }
                        else
                        { 
                            The_m = 60;
                        }
                    }
                    break;

                case 8:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Fri_h < 24)
                        {
                            Fri_h++;
                        }
                        else
                        {
                            Fri_h = 0;
                        }
                    }
                    else
                    {
                        if (Fri_h > 0)
                        {
                            Fri_h--;
                        }
                        else
                        {
                            Fri_h = 24;
                        }
                    }
                    break;

                case 9:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Fri_m < 60)
                        {
                            Fri_m += 10;
                        }
                        else
                        {
                            Fri_m = 0;
                        }
                    }
                    else
                    {
                        if (Fri_m > 0)
                        {
                            Fri_m -= 10;
                        }
                        else
                        {
                            Fri_m = 60;
                        }
                    }
                    break;

                case 10:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Sat_h < 24)
                        {
                            Sat_h++;
                        }
                        else
                        {
                            Sat_h = 0;
                        }
                    }
                    else
                    {
                        if (Sat_h > 0)
                        {
                            Sat_h--;
                        }
                        else
                        {
                            Sat_h = 24;
                        }
                    }
                    break;

                case 11:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Sat_m < 60)
                        {
                            Sat_m += 10;
                        }
                        else
                        {
                            Sat_m = 0;
                        }
                    }
                    else
                    {
                        if (Sat_m > 0)
                        {
                            Sat_m -= 10;
                        }
                        else
                        {
                            Sat_m = 60;
                        }
                    }
                    break;

                case 12:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Sun_h < 24)
                        {
                            Sun_h++;
                        }
                        else
                        {
                            Sun_h = 0;
                        }
                    }
                    else
                    {
                        if (Sun_h > 0)
                        {
                            Sun_h--;
                        }
                        else
                        {
                            Sun_h = 24;
                        }
                    }
                    break;

                case 13:
                    if (Input.GetAxisRaw("Vertical") == 1)
                    {
                        if (Sun_m < 60)
                        {
                            Sun_m += 10;
                        }
                        else
                        {
                            Sun_m = 0;
                        }
                    }
                    else
                    {
                        if (Sun_m > 0)
                        {
                            Sun_m -= 10;
                        }
                        else
                        {
                            Sun_m = 60;
                        }
                    }
                    break;
            }
            
            if(Mon_h == 24 && Mon_m == 60)
            {
                Mon.text = "- - :- -";
            }else if(Mon_h == 24 && Mon_m == 0)
            {
                Mon.text = "- - :00"; 
            }
            else if(Mon_h == 24)
            {
                Mon.text = "- - :" + Mon_m.ToString();
            }
            else if (Mon_h < 10 && Mon_m == 60)
            {
                Mon.text = "0" + Mon_h.ToString() + ":- -";
            }
            else if(Mon_m == 60)
            {
                Mon.text = Mon_h.ToString() + ":- -";
            }else if(Mon_h < 10 && Mon_m == 0)
            {
                Mon.text = "0" + Mon_h.ToString() + ":00";
            }else if(Mon_m == 0)
            {
                Mon.text = Mon_h.ToString() + ":00";
            }else if(Mon_h < 10)
            {
                Mon.text = "0" + Mon_h.ToString() + ":" + Mon_m.ToString();
            }
            else
            {
                Mon.text = Mon_h.ToString() + ":" +Mon_m.ToString();
            }


            if (Thu_h == 24 && Thu_m == 60)
            {
                Thu.text = "- - :- -";
            }else if(Thu_h == 24 && Thu_m == 0)
            {
                Thu.text = "- - :00";
            }
            else if (Thu_h == 24)
            {
                Thu.text = "- - :" + Thu_m.ToString();
            }
            else if (Thu_h < 10 && Thu_m == 60)
            {
                Thu.text = "0" + Thu_h.ToString() + ":- -";
            }
            else if (Thu_m == 60)
            {
                Thu.text = Thu_h.ToString() + ":- -";
            }
            else if (Thu_h < 10 && Thu_m == 0)
            {
                Thu.text = "0" + Thu_h.ToString() + ":00";
            }
            else if (Thu_m == 0)
            {
                Thu.text = Thu_h.ToString() + ":00";
            }
            else if (Thu_h < 10)
            {
                Thu.text = "0" + Thu_h.ToString() + ":" + Thu_m.ToString();
            }
            else
            {
                Thu.text = Thu_h.ToString() + ":" + Thu_m.ToString();
            }


            if (Wed_h == 24 && Wed_m == 60)
            {
                Wed.text = "- - :- -";
            }else if(Wed_h == 24 && Wed_m == 0)
            {
                Wed.text = "- - :00";
            }
            else if (Wed_h == 24)
            {
                Wed.text = "- - :" + Wed_m.ToString();
            }
            else if (Wed_h < 10 && Wed_m == 60)
            {
                Wed.text = "0" + Wed_h.ToString() + ":- -";
            }
            else if (Wed_m == 60)
            {
                Wed.text = Wed_h.ToString() + ":- -";
            }
            else if (Wed_h < 10 && Wed_m == 0)
            {
                Wed.text = "0" + Wed_h.ToString() + ":00";
            }
            else if (Wed_m == 0)
            {
                Wed.text = Wed_h.ToString() + ":00";
            }
            else if (Wed_h < 10)
            {
                Wed.text = "0" + Wed_h.ToString() + ":" + Wed_m.ToString();
            }
            else
            {
                Wed.text = Wed_h.ToString() + ":" + Wed_m.ToString();
            }


            if (The_h == 24 && The_m == 60)
            {
                The.text = "- - :- -";
            }else if(The_h == 24 && Thu_m == 0)
            {
                The.text = "- - :00";
            }
            else if (The_h == 24)
            {
                The.text = "- - :" + The_m.ToString();
            }
            else if (The_h < 10 && The_m == 60)
            {
                The.text = "0" + The_h.ToString() + ":- -";
            }
            else if (The_m == 60)
            {
                The.text = The_h.ToString() + ":- -";
            }
            else if (The_h < 10 && The_m == 0)
            {
                The.text = "0" + The_h.ToString() + ":00";
            }
            else if (The_m == 0)
            {
                The.text = The_h.ToString() + ":00";
            }
            else if (The_h < 10)
            {
                The.text = "0" + The_h.ToString() + ":" + The_m.ToString();
            }
            else
            {
                The.text = The_h.ToString() + ":" + The_m.ToString();
            }


            if (Fri_h == 24 && Fri_m == 60)
            {
                Fri.text = "- - :- -";
            }else if(Fri_h == 24 && Fri_m == 0)
            {
                Fri.text = "- - :00";
            }
            else if (Fri_h == 24)
            {
                Fri.text = "- - :" + Fri_m.ToString();
            }
            else if (Fri_h < 10 && Fri_m == 60)
            {
                Fri.text = "0" + Fri_h.ToString() + ":- -";
            }
            else if (Fri_m == 60)
            {
                Fri.text = Fri_h.ToString() + ":- -";
            }
            else if (Fri_h < 10 && Fri_m == 0)
            {
                Fri.text = "0" + Fri_h.ToString() + ":00";
            }
            else if (Fri_m == 0)
            {
                Fri.text = Fri_h.ToString() + ":00";
            }
            else if (Fri_h < 10)
            {
                Fri.text = "0" + Fri_h.ToString() + ":" + Fri_m.ToString();
            }
            else
            {
                Fri.text = Fri_h.ToString() + ":" + Fri_m.ToString();
            }


            if (Sat_h == 24 && Sat_m == 60)
            {
                Sat.text = "- - :- -";
            }else if(Sat_h == 24 && Sat_m == 0)
            {
                Sat.text = "- - :00";
            }
            else if (Sat_h == 24)
            {
                Sat.text = "- - :" + Sat_m.ToString();
            }
            else if (Sat_h < 10 && Sat_m == 60)
            {
                Sat.text = "0" + Sat_h.ToString() + ":- -";
            }
            else if (Sat_m == 60)
            {
                Sat.text = Sat_h.ToString() + ":- -";
            }
            else if (Sat_h < 10 && Sat_m == 0)
            {
                Sat.text = "0" + Sat_h.ToString() + ":00";
            }
            else if (Sat_m == 0)
            {
                Sat.text = Sat_h.ToString() + ":00";
            }
            else if (Sat_h < 10)
            {
                Sat.text = "0" + Sat_h.ToString() + ":" + Sat_m.ToString();
            }
            else
            {
                Sat.text = Sat_h.ToString() + ":" + Sat_m.ToString();
            }


            if (Sun_h == 24 && Sun_m == 60)
            {
                Sun.text = "- - :- -";
            }else if(Sun_h == 24 && Sun_m == 0)
            {
                Sun.text = "- - :00";
            }
            else if (Sun_h == 24)
            {
                Sun.text = "--:" + Sun_m.ToString();
            }
            else if(Sun_h < 10 && Sun_m == 60)
            {
                Sun.text = "0" + Sun_h.ToString() + ":--";
            }
            else if (Sun_m == 60)
            {
                Sun.text = Sun_h.ToString() + ":--";
            }
            else if (Sun_h < 10 && Sun_m == 0)
            {
                Sun.text = "0" + Sun_h.ToString() + ":00";
            }
            else if (Sun_m == 0)
            {
                Sun.text = Sun_h.ToString() + ":00";
            }
            else if (Sun_h < 10)
            {
                Sun.text = "0" + Sun_h.ToString() + ":" + Sun_m.ToString();
            }
            else
            {
                Sun.text = Sun_h.ToString() + ":" + Sun_m.ToString();
            }
            System.Threading.Thread.Sleep(200);
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator Yabai()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            n += (int)Input.GetAxisRaw("Horizontal");
            
            System.Threading.Thread.Sleep(200);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
