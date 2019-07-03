using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class income : MonoBehaviour {

    public Text texts;
    int _time;
    float __times;
    
    public GameObject gms;
    int money;
    int pop;
    int seyule;
    void Start () {
        _time = 30;
        gms = GameObject.FindWithTag("GMS");
        money = gms.GetComponent<GameManager>().money;
        pop = gms.GetComponent<GameManager>().POPLUATION;
        seyule = gms.GetComponent<GameManager>().seyule;
    }

	
	// Update is called once per frame
	void Update () {
        //if (Singleton.Instance.stop == false)
        {
            __times += Time.smoothDeltaTime;
            if(__times > 1)
            {
                __times = 0;
                _time--;
            }

                texts.text = "INCOME : " + _time.ToString();
            if(_time < 0)
            {
                gms.GetComponent<GameManager>().money += pop * gms.GetComponent<GameManager>().seyule*10 + 15000;
                seyuleselect();
                _time = 30;
            }
            
        }
        	
	}
    void seyuleselect()
    {
        if(gms.GetComponent<GameManager>().seyule > 10 && gms.GetComponent<GameManager>().seyule < 20)
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 2;
        }
        if (gms.GetComponent<GameManager>().seyule > 20 && gms.GetComponent<GameManager>().seyule < 30)
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 5;
        }
        if (gms.GetComponent<GameManager>().seyule > 30 && gms.GetComponent<GameManager>().seyule < 40)
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 13;
        }
        if (gms.GetComponent<GameManager>().seyule > 40 && gms.GetComponent<GameManager>().seyule < 50)
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 42;
        }
        if (gms.GetComponent<GameManager>().seyule > 50 && gms.GetComponent<GameManager>().seyule < 60)
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 80;
        }
        if (gms.GetComponent<GameManager>().seyule > 60 )
        {
            gms.GetComponent<GameManager>().ENVIROMENT -= 99;
        }
    }

}
