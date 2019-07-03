using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_1 : MonoBehaviour {

    public int fgam = 1;
    int s;
    float _time = 0;
    float __time = 0;
    public Text sfse;
    public GameObject Canvas;
    public GameObject Popup;
    public GameObject showbar;
    public GameObject shsh;
    public GameObject upgradePopup;
    public GameObject segumepopup;
    public GameObject gms;
    public GameObject blacks;
    Image bleks;
    public Text tss;
    public Text te;
    int money;
    int minsim;
    int seyule = 10;
    bool show = false;
    bool shows = false;
    void Start()
    {
        gms = GameObject.FindWithTag("GMS");
        money = gms.GetComponent<GameManager>().money;
        minsim = gms.GetComponent<GameManager>().ENVIROMENT;
    } 
    void Update () {
        if (shows == true)
        {
            _time += Time.smoothDeltaTime;
                if (show == true)
                {
                    showbar.transform.localPosition = Vector3.Lerp(new Vector3(-568, 0, 0), new Vector3(-716, 0, 0), Time.smoothDeltaTime);
                }
                else if (show == false)
                {
                    showbar.transform.localPosition = Vector3.Lerp(new Vector3(-716, 0, 0), new Vector3(-568, 0, 0), Time.smoothDeltaTime);
                }
            if(_time > 0.4f)
            {
                shows = false;
                _time = 0;
                if (show == true) show = false;
                else show = true;
            }
        }
      
    }
    public void popupoff()
    {
        segumepopup.SetActive(false);
    }
    public void skekf()
    {
        
            int c = fgam * 2000000;
            sfse.text = "도시 레벨 : " + fgam.ToString() + "\n  업그레이드 비용 : " + c.ToString();
            fgam++;
        
    }
    public void plusminus(int si)
    {
        switch (si)
        {
            case 1:
                gms.GetComponent<GameManager>().seyule++;
                
                break;
            case 2:
                gms.GetComponent<GameManager>().seyule--;
                break;
        }
        tss.text = gms.GetComponent<GameManager>().seyule.ToString();

        Debug.Log(seyule);
    }
    public void GetButtonDowns(int a)
    {
        Canvas = GameObject.FindWithTag("Canvas");

        switch (a)
        {
            case 1:
                ANEM();
                break;
            case 2:
                ANEM();
                break;
            case 3:
                ANEM();
                break;
            case 4:
                ANEM();
                break;
            case 5:
                ANEM();
                break;
        }
        Destroy(gameObject);
    }
    void ANEM()
    {
        GameObject a = Instantiate(Popup, new Vector3(), transform.rotation);
        a.transform.SetParent(Canvas.transform);
        a.transform.localPosition = new Vector3(0, 115, 0);
    }
    public void POPUPs(int a)
    {
        switch (a)
        {
            case 1:                                 // 종료
                Destroy(GameObject.FindWithTag("popup"));
                gms.GetComponent<GameManager>().ENVIROMENT -= 5;
                break;
            case 2:                             // OK
                if (gms.GetComponent<GameManager>().money > 70000)
                {
                    Destroy(GameObject.FindWithTag("popup"));
                    gms.GetComponent<GameManager>().money -= 70000;
                    gms.GetComponent<GameManager>().ENVIROMENT += 2;
                }

                break;
        }
    }
    void SEP()
    {
        te.text = "시장님 댐에 폐수가 흐르고있어요!강과 나무가 오염되기전에 오염을 막아주세요!";
    }
    public void showbars()
    {
        shows = true;
    }
    public void open(int a)
    {
        if (a == 1) upgradePopup.SetActive(true);
        else if (a == 2) upgradePopup.SetActive(false);
    }
    public void sopen()
    {
        segumepopup.SetActive(true);
    }
}   
        