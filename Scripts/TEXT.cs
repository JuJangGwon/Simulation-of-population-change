using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TEXT : MonoBehaviour {

    public Text sf;
    void Start()
    {
        int random_n = Random.Range(1, 6);
        switch (random_n)
        {
            case 1:
                sf.text = "시장님 댐에 폐수가 흐르고있어요! \n 강과 나무가 오염되기전에오염을 막아주세요!";
                break;
            case 2:
                sf.text = "시장님 차로가 꽉 막혀서 움직일수가 없어요!\n 도로좀 넓혀주세요!-";
                break;
            case 3:
                sf.text = "시장님 소음때문에 밤에 잠을 잘 수 없어요! 이 지긋지긋한 소음좀 줄여주세요!";
                break;
            case 4:
                sf.text = "시장님 밖이 너무 흉흉해서 다닐 수가 없어요! \n  치안을 강화해주세요!";
                break;
            case 5:
                sf.text = "시장님 시민들의 살 곳이 없어요! 따뜻한 밤을 보낼 수 있게 집을 지어주세요! ";
                break;

        }

    }
}
