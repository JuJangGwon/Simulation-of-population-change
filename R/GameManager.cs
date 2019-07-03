using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    int fgam;
    float __time = 0;
    public GameObject Canvas;
    public GameObject Stk;
    public GameObject building;
    public GameObject aprtbuildbox;
    public GameObject s;
    public Text[] text;
    public GameObject blacks;
    Image bleks;

    int wave = 0;
    int stage = 0;
    int random_n = 0;
    float pop_time;
    float _time = 0;
    float _stime = 0;
    float Gametime = 0;
    
    bool show = false;

    public int seyule = 10;
    public int money;
    public int POPLUATION = 1000;
    public int ENVIROMENT = 70;
    public int SYSTEM = 50;
    public int satisfaction = 70;

    public int[] distinct = new int[3];
    public int[] buildLevel = new int[8];
    public int[,] needbuildmoney = new int[8,3];
    public GameObject upgradepopup;

    void Start () {
        bleks = blacks.GetComponent<Image>();
        fgam = s.GetComponent<Button_1>().fgam;
        needbuildmoney[0,0] = 5000000;
       needbuildmoney[1,0] = 3000000;
       needbuildmoney[2,0] = 9000000;
       needbuildmoney[3,0] = 11000000;
       needbuildmoney[4,0] = 17000000;
       needbuildmoney[5,0] = 8000000;
       needbuildmoney[6,0] = 20000000;
       needbuildmoney[7,0] = 4000000;
       needbuildmoney[0,1] = 35000000;
       needbuildmoney[1,1] = 43000000;
       needbuildmoney[2,1] = 59000000;
       needbuildmoney[3,1] = 61000000;
       needbuildmoney[4,1] = 67000000;
       needbuildmoney[5,1] = 48000000;
       needbuildmoney[6,1] = 80000000;
       needbuildmoney[7,1] = 38000000;
       needbuildmoney[0,2] = 143000000;
       needbuildmoney[1,2] = 125000000;
       needbuildmoney[2,2] = 159000000;
       needbuildmoney[3,2] = 170000000;
       needbuildmoney[4,2] = 200000000;
       needbuildmoney[5,2] = 180000000;
       needbuildmoney[6,2] = 240000000;
       needbuildmoney[7,2] = 160000000;
        money = 400000;
    
            distinct[0] = 0;
            distinct[1] = 0;
            distinct[2] = 0;
            for (int i = 0; i < 8; i++) buildLevel[i] = 0;
    }

    void Update () {
        if(Input.GetKeyDown(KeyCode.F7))
        {
            money = 999999999;
        }
        Debug.Log(money);
        _stime += Time.smoothDeltaTime;
            pop_time += Time.smoothDeltaTime;
            Gametime += Time.smoothDeltaTime;
            _time += Time.smoothDeltaTime;
            text[0].text = money.ToString();
            text[1].text = POPLUATION.ToString();
            text[2].text = ENVIROMENT.ToString();
            text[3].text = SYSTEM.ToString();
            text[4].text = satisfaction.ToString();
            if (_time > 3)
            {
                int random_n = Random.Range(1, 9);
                for (int i = 0; i < 20; i++)
                {
                    if (random_n == distinct[0]) random_n = Random.Range(1, 9);
                    if (random_n == distinct[1]) random_n = Random.Range(1, 9);
                    if (random_n == distinct[2]) random_n = Random.Range(1, 9);
                }
                _time = 0;
                Debug.Log(random_n);
                select(random_n);
            }
            if(_stime > 8)
             {
            _stime = 0;
            POPLUATION -= 2;
             }

            if (pop_time > 1)
            {
                POPLUATION++;
                if (fgam == 1) POPLUATION++;
                if (fgam == 2) POPLUATION += 2;
                if (fgam >= 3) POPLUATION += 4;
                pop_time = 0;
            }
      
    }
    void select(int rand)
    {
        switch(rand)
        {
            case 1:
                GameObject ask = Instantiate(Stk,transform.position, transform.rotation) as GameObject;
                ask.transform.parent = Canvas.transform;
                ask.transform.localPosition = new Vector3(-166, 261);
                dist(1);
                break;
            case 2:
                GameObject ask2 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask2.transform.parent = Canvas.transform;
                ask2.transform.localPosition = new Vector3(92, 174);
                dist(2);
                break;
            case 3:
                GameObject ask3 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask3.transform.parent = Canvas.transform;
                ask3.transform.localPosition = new Vector3(319 , 174);
                dist(3);

                break;
            case 4: 
                GameObject ask4 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask4.transform.parent = Canvas.transform;
                ask4.transform.localPosition = new Vector3(-237, 115);
                dist(4);

                break;
            case 5:
                GameObject ask5 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask5.transform.parent = Canvas.transform;
                ask5.transform.localPosition = new Vector3(-345, -43.4f);
                dist(5);

                break;
            case 6:
                GameObject ask6 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask6.transform.parent = Canvas.transform;
                ask6.transform.localPosition = new Vector3(-83, -133);
                dist(6);

                break;
            case 7:
                GameObject ask7 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask7.transform.parent = Canvas.transform;
                ask7.transform.localPosition = new Vector3(242, -72);
                dist(7);

                break;
            case 8:
                GameObject ask8 = Instantiate(Stk, transform.position, transform.rotation) as GameObject;
                ask8.transform.parent = Canvas.transform;
                ask8.transform.localPosition = new Vector3(185, -235);
                dist(8);

                break;
        }
    }
   
    void dist(int nums)
    {
        distinct[2] = distinct[1];
        distinct[1] = distinct[0];
        distinct[0] = nums;
    }
   
    public void upgradebuildingpopup(int ts)
    {
      //  if(a== 2)
        {
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       

       
       
       

       
       
        }
    }
}

//-716 , -568
