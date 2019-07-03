using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status : MonoBehaviour {

    int I = 0;
    public Text money_t;
    Text pop_t;
    Text like_t;
    Text fun_t;
    Text envir_t;
    GameManager gm;
    public GameObject gms;
    public GameObject textsf;

    public GameObject building;
    public GameObject building2;
    public GameObject building3;
    public GameObject aprtbuildbox;
    public GameObject aprtbuildbox2;
    public GameObject aprtbuildbox3;
    public GameObject aprtbuildbox4;
    public GameObject aprtbuildbox5;
    public GameObject aprtbuildbox6;
    public GameObject aprtbuildbox7;
    public GameObject aprtbuildbox8;
    public GameObject aprtbuildbox9;
    public GameObject aprtbuildbox10;
    public GameObject aprtbuildbox11;
    public GameObject aprtbuildbox12;
    public GameObject aprtbuildbox13;
    public GameObject aprtbuildbox14;
    public GameObject aprtbuildbox15;
    public GameObject aprtbuildbox16;
    public GameObject aprtbuildbox17;
    public GameObject aprtbuildbox18;
    public GameObject upgradepopup;
    public GameObject firestiaon1;
    public GameObject firestiaon2;
    public GameObject firestiaon3;
    public GameObject forest1;
    public GameObject forest2;
    public GameObject forest3;
    public GameObject ffirestiaon1;
    public GameObject ffirestiaon2;
    public GameObject ffirestiaon3;
    public GameObject fforest1;
    public GameObject fforest2;
    public GameObject fforest3;

    int POPLUATION = 1000;
    int ENVIROMENT = 70;
    int SYSTEM = 50;
    int satisfaction = 70;
    int money = 0;
    int[] distinct = new int[3];
    int[] buildLevel = new int[8];
    int[,] needbuildmoney = new int[8, 3];
    float _time = 0;
    void Awake() {
        money = gms.GetComponent<GameManager>().money;
        POPLUATION = gms.GetComponent<GameManager>().POPLUATION;
        ENVIROMENT = gms.GetComponent<GameManager>().ENVIROMENT;
        SYSTEM = gms.GetComponent<GameManager>().SYSTEM;
        satisfaction = gms.GetComponent<GameManager>().satisfaction;

        distinct = gms.GetComponent<GameManager>().distinct;
        buildLevel = gms.GetComponent<GameManager>().buildLevel;
        needbuildmoney = gms.GetComponent<GameManager>().needbuildmoney;
    }
 
   void Update()
   {
       _time += Time.smoothDeltaTime;
       //if (_time > 3 && _time <3.3f)
       //{
       //    Singleton.Instance.GoLD = money;
       //}
       //if (_time > 3)
       //{
       //    money_t.text = Singleton.Instance.GoLD.ToString();
       //}
       
        Debug.Log(money);
    }
    public void d(int ts)
   {
      // if (needbuildmoney[ts - 1, buildLevel[ts - 1]] < money)
       {
        //   gms.GetComponent<GameManager>().money -= needbuildmoney[ts - 1, buildLevel[ts - 1]];
          // buildLevel[ts - 1]++;

            if (ts == 2)
            {
                
                upgradepopup.SetActive(false);
                I++;
                //if (buildLevel[ts - 1] == 1)
                //{
                //    GameObject a1 = Instantiate(building, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                //    GameObject a2 = Instantiate(building, new Vector3(133.5f, 107.5f, 0), transform.rotation);
                //    GameObject a3 = Instantiate(building, new Vector3(133.5f, 258.5002f, 0), transform.rotation);
                //    GameObject a4 = Instantiate(building, new Vector3(12, 275, 0), transform.rotation);
                //    a1.transform.SetParent(aprtbuildbox.transform);
                //    a2.transform.SetParent(aprtbuildbox.transform);
                //    a3.transform.SetParent(aprtbuildbox.transform);
                //    a4.transform.SetParent(aprtbuildbox.transform);
                //    a1.transform.localPosition = new Vector3(5.7f, 108.4f, 0);
                //    a2.transform.localPosition = new Vector3(133.5f, 107.5f, 0);
                //    a3.transform.localPosition = new Vector3(133.5f, 258.5002f, 0);
                //    a4.transform.localPosition = new Vector3(12, 275, 0);
                //}
                //if (buildLevel[ts - 1] == 2)
                //{
                //    GameObject a1 = Instantiate(building2, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                //    GameObject a2 = Instantiate(building2, new Vector3(133.5f, 107.5f, 0), transform.rotation);
                //    GameObject a3 = Instantiate(building2, new Vector3(133.5f, 258.5002f, 0), transform.rotation);
                //    GameObject a4 = Instantiate(building2, new Vector3(12, 275, 0), transform.rotation);
                //    a1.transform.SetParent(aprtbuildbox2.transform);
                //    a2.transform.SetParent(aprtbuildbox2.transform);
                //    a3.transform.SetParent(aprtbuildbox2.transform);
                //    a4.transform.SetParent(aprtbuildbox2.transform);
                //    a1.transform.localPosition = new Vector3(5.7f, 108.4f, 0);
                //    a2.transform.localPosition = new Vector3(133.5f, 107.5f, 0);
                //    a3.transform.localPosition = new Vector3(133.5f, 258.5002f, 0);
                //    a4.transform.localPosition = new Vector3(12, 275, 0);
                //    Destroy(aprtbuildbox);
                //}
                //if (buildLevel[ts - 1] == 3)
                //{
                //    GameObject a3 = Instantiate(building3, new Vector3(5.700012f, 255, 0), transform.rotation);
                //    GameObject a4 = Instantiate(building3, new Vector3(133.5f, 252, 0), transform.rotation);
                //    GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);
                //    GameObject a2 = Instantiate(building3, new Vector3(154, 148, 0), transform.rotation);
                //    a1.transform.SetParent(aprtbuildbox3.transform);
                //    a2.transform.SetParent(aprtbuildbox3.transform);
                //    a3.transform.SetParent(aprtbuildbox3.transform);
                //    a4.transform.SetParent(aprtbuildbox3.transform);
                //    a1.transform.localPosition = new Vector3(5.700012f, 255, 0);
                //    a2.transform.localPosition = new Vector3(133.5f, 252, 0);
                //    a3.transform.localPosition = new Vector3(31, 147, 0);
                //    a4.transform.localPosition = new Vector3(154, 148, 0);
                //    Destroy(aprtbuildbox2);
                //}
                if (gms.GetComponent<GameManager>().money > I * 2000000)
                {
                    gms.GetComponent<GameManager>().money -= I * 2000000;

                    if (I == 1)
                    {
                        GameObject a1 = Instantiate(building, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        GameObject a2 = Instantiate(building, new Vector3(133.5f, 107.5f, 0), transform.rotation);
                        GameObject a3 = Instantiate(building, new Vector3(133.5f, 258.5002f, 0), transform.rotation);
                        GameObject a4 = Instantiate(building, new Vector3(12, 275, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox.transform);
                        a2.transform.SetParent(aprtbuildbox.transform);
                        a3.transform.SetParent(aprtbuildbox.transform);
                        a4.transform.SetParent(aprtbuildbox.transform);
                        a1.transform.localPosition = new Vector3(5.7f, 108.4f, 0);
                        a2.transform.localPosition = new Vector3(133.5f, 107.5f, 0);
                        a3.transform.localPosition = new Vector3(133.5f, 258.5002f, 0);
                        a4.transform.localPosition = new Vector3(12, 275, 0);
                    }
                    if (I == 2)
                    {
                        GameObject a1 = Instantiate(building2, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        GameObject a2 = Instantiate(building2, new Vector3(133.5f, 107.5f, 0), transform.rotation);
                        GameObject a3 = Instantiate(building2, new Vector3(133.5f, 258.5002f, 0), transform.rotation);
                        GameObject a4 = Instantiate(building2, new Vector3(12, 275, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox2.transform);
                        a2.transform.SetParent(aprtbuildbox2.transform);
                        a3.transform.SetParent(aprtbuildbox2.transform);
                        a4.transform.SetParent(aprtbuildbox2.transform);
                        a1.transform.localPosition = new Vector3(5.7f, 108.4f, 0);
                        a2.transform.localPosition = new Vector3(133.5f, 107.5f, 0);
                        a3.transform.localPosition = new Vector3(133.5f, 258.5002f, 0);
                        a4.transform.localPosition = new Vector3(12, 275, 0);
                        Destroy(aprtbuildbox);
                    }
                    if (I == 3)
                    {
                        GameObject a3 = Instantiate(building3, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a4 = Instantiate(building3, new Vector3(133.5f, 252, 0), transform.rotation);
                        GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);
                        GameObject a2 = Instantiate(building3, new Vector3(154, 148, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox3.transform);
                        a2.transform.SetParent(aprtbuildbox3.transform);
                        a3.transform.SetParent(aprtbuildbox3.transform);
                        a4.transform.SetParent(aprtbuildbox3.transform);
                        a1.transform.localPosition = new Vector3(5.700012f, 255, 0);
                        a2.transform.localPosition = new Vector3(133.5f, 252, 0);
                        a3.transform.localPosition = new Vector3(31, 147, 0);
                        a4.transform.localPosition = new Vector3(154, 148, 0);
                        Destroy(aprtbuildbox2);
                    }
                    if (I == 4)
                    {
                        GameObject a3 = Instantiate(building, new Vector3(-172, -62, 0), transform.rotation);
                        GameObject a4 = Instantiate(building, new Vector3(-32, -62, 0), transform.rotation);
                        GameObject a1 = Instantiate(building, new Vector3(12, -195.6f, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox4.transform);
                        a3.transform.SetParent(aprtbuildbox4.transform);
                        a4.transform.SetParent(aprtbuildbox4.transform);
                        a1.transform.localPosition = new Vector3(-172, -62, 0);
                        a3.transform.localPosition = new Vector3(-32, -62, 0);
                        a4.transform.localPosition = new Vector3(12, -195.6f, 0);
                        Destroy(aprtbuildbox2);
                    }
                    if (I == 5)
                    {
                        GameObject a3 = Instantiate(building2, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a1 = Instantiate(building2, new Vector3(31, 147, 0), transform.rotation);
                        GameObject a2 = Instantiate(building2, new Vector3(154, 148, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox5.transform);
                        a2.transform.SetParent(aprtbuildbox5.transform);
                        a3.transform.SetParent(aprtbuildbox5.transform);
                        a1.transform.localPosition = new Vector3(-172, -62, 0);
                        a2.transform.localPosition = new Vector3(-32, -62, 0);
                        a3.transform.localPosition = new Vector3(12, -195.6f, 0);
                        Destroy(aprtbuildbox4);
                    }
                    if (I == 6)
                    {
                        GameObject a3 = Instantiate(building3, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a4 = Instantiate(building3, new Vector3(133.5f, 252, 0), transform.rotation);
                        GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox6.transform);
                        a3.transform.SetParent(aprtbuildbox6.transform);
                        a4.transform.SetParent(aprtbuildbox6.transform);
                        a1.transform.localPosition = new Vector3(-172, 0, 0);
                        a3.transform.localPosition = new Vector3(-32, -62, 0);
                        a4.transform.localPosition = new Vector3(21, -195.6f, 0);
                        Destroy(aprtbuildbox5);
                    }
                    if (I == 7)
                    {
                        GameObject a1 = Instantiate(firestiaon1, new Vector3(12, -195.6f, 0), transform.rotation);
                        a1.transform.SetParent(ffirestiaon1.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;
                        a1.transform.localPosition = new Vector3(-221.2f, 82, 0);
                    }
                    if (I == 8)
                    {
                        GameObject a2 = Instantiate(firestiaon2, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a1 = Instantiate(firestiaon2, new Vector3(31, 147, 0), transform.rotation);

                        a1.transform.SetParent(ffirestiaon2.transform);
                        a2.transform.SetParent(ffirestiaon2.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;

                        a1.transform.localPosition = new Vector3(-305.2f, 82, 0);
                        a2.transform.localPosition = new Vector3(-160.4f, 81.3f, 0);

                        Destroy(ffirestiaon1);
                    }
                    if (I == 9)
                    {
                        GameObject a3 = Instantiate(firestiaon3, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a4 = Instantiate(firestiaon3, new Vector3(133.5f, 252, 0), transform.rotation);
                        GameObject a1 = Instantiate(firestiaon3, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(ffirestiaon3.transform);
                        a3.transform.SetParent(ffirestiaon3.transform);
                        a4.transform.SetParent(ffirestiaon3.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;

                        a1.transform.localPosition = new Vector3(-362.3f, 82, 0);
                        a3.transform.localPosition = new Vector3(-234.6f, 82, 0);
                        a4.transform.localPosition = new Vector3(-116.7f, 81.3f, 0);
                        Destroy(ffirestiaon2);
                    }
                    if (I == 10)
                    {
                        GameObject a1 = Instantiate(building, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox7.transform);
                        a1.transform.localPosition = new Vector3(-353, -55, 0);
                    }
                    if (I == 11)
                    {
                        GameObject a1 = Instantiate(building2, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox8.transform);
                        a1.transform.localPosition = new Vector3(-353, -55, 0);
                        Destroy(aprtbuildbox7);
                    }
                    if (I == 12)
                    {
                        GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox9.transform);
                        a1.transform.localPosition = new Vector3(-353, -25, 0);
                        Destroy(aprtbuildbox8);
                    }
                    if (I == 13)
                    {
                        GameObject a1 = Instantiate(building, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox10.transform);
                        a1.transform.localPosition = new Vector3(-171, 276, 0);
                    }
                    if (I == 14)
                    {
                        GameObject a1 = Instantiate(building2, new Vector3(5.7f, 108.4f, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox11.transform);
                        a1.transform.localPosition = new Vector3(-171, 276, 0);
                        Destroy(aprtbuildbox10);
                    }
                    if (I == 15)
                    {
                        GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox12.transform);
                        a1.transform.localPosition = new Vector3(-171, 276, 0);
                        Destroy(aprtbuildbox11);
                    }
                    if (I == 16)
                    {
                        GameObject a3 = Instantiate(forest1, new Vector3(-172, -62, 0), transform.rotation);
                        GameObject a4 = Instantiate(forest1, new Vector3(-32, -62, 0), transform.rotation);
                        GameObject a1 = Instantiate(forest1, new Vector3(12, -195.6f, 0), transform.rotation);
                        a1.transform.SetParent(fforest1.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;

                        a3.transform.SetParent(fforest1.transform);
                        a4.transform.SetParent(fforest1.transform);
                        a1.transform.localPosition = new Vector3(142, -62, 0);
                        a3.transform.localPosition = new Vector3(245, -62, 0);
                        a4.transform.localPosition = new Vector3(347.3f, -62, 0);
                    }
                    if (I == 17)
                    {
                        GameObject a3 = Instantiate(forest2, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a1 = Instantiate(forest2, new Vector3(31, 147, 0), transform.rotation);
                        GameObject a2 = Instantiate(forest2, new Vector3(154, 148, 0), transform.rotation);
                        a1.transform.SetParent(fforest2.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;

                        a2.transform.SetParent(fforest2.transform);
                        a3.transform.SetParent(fforest2.transform);
                        a1.transform.localPosition = new Vector3(142, -62, 0);
                        a3.transform.localPosition = new Vector3(245, -62, 0);
                        a2.transform.localPosition = new Vector3(347.3f, -62, 0);
                        Destroy(fforest1);
                    }
                    if (I == 18)
                    {
                        GameObject a3 = Instantiate(forest3, new Vector3(5.700012f, 255, 0), transform.rotation);
                        GameObject a4 = Instantiate(forest3, new Vector3(133.5f, 252, 0), transform.rotation);
                        GameObject a1 = Instantiate(forest3, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(fforest3.transform);
                        gms.GetComponent<GameManager>().SYSTEM += 5;

                        a3.transform.SetParent(fforest3.transform);
                        a4.transform.SetParent(fforest3.transform);
                        a1.transform.localPosition = new Vector3(142, -62, 0);
                        a3.transform.localPosition = new Vector3(245, -62, 0);
                        a4.transform.localPosition = new Vector3(347.3f, -62, 0);
                        Destroy(fforest2);
                    }
                    if (I == 19)
                    {
                        GameObject a1 = Instantiate(building, new Vector3(31, 147, 0), transform.rotation);
                        a1.transform.SetParent(aprtbuildbox13.transform);
                        a1.transform.localPosition = new Vector3(290.4f, 159.8f, 0);
                    }
                    if (I == 20)
                    {
                        GameObject a2 = Instantiate(building2, new Vector3(5.700012f, 255, 0), transform.rotation);
                        a2.transform.SetParent(aprtbuildbox14.transform);
                        a2.transform.localPosition = new Vector3(290.4f, 159.8f, 0);
                        Destroy(aprtbuildbox13);
                    }
                    if (I == 21)
                    {
                        GameObject a2 = Instantiate(building3, new Vector3(5.700012f, 255, 0), transform.rotation);
                        a2.transform.SetParent(aprtbuildbox15.transform);
                        a2.transform.localPosition = new Vector3(290.4f, 159.8f, 0);
                        Destroy(aprtbuildbox14);
                    }
                    if (I == 22)
                    {
                        GameObject a1 = Instantiate(building, new Vector3(31, 147, 0), transform.rotation);

                        a1.transform.SetParent(aprtbuildbox16.transform);
                        a1.transform.localPosition = new Vector3(184, -237.1f, 0);
                    }
                    if (I == 23)
                    {
                        GameObject a1 = Instantiate(building2, new Vector3(31, 147, 0), transform.rotation);

                        a1.transform.SetParent(aprtbuildbox17.transform);
                        a1.transform.localPosition = new Vector3(184, -237.1f, 0);
                        Destroy(aprtbuildbox16);
                    }
                    if (I == 24)
                    {
                        GameObject a1 = Instantiate(building3, new Vector3(31, 147, 0), transform.rotation);

                        a1.transform.SetParent(aprtbuildbox18.transform);
                        a1.transform.localPosition = new Vector3(184, -190, 0);
                        Destroy(aprtbuildbox17);
                    }
                }
            }
        }
   }

}
