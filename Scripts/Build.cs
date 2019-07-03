using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour {

    int a;
    
	void Start () {
	    for (int i = 0; i<8;i++)
        {
            Singleton.Instance.buildlevel[i] = 0;
        }
	}

    void Builds(int num)
    {
            if(Singleton.Instance.buildlevel[num-1] != 4)
            Singleton.Instance.buildlevel[num-1]++;
    }
    void Buildb(int num)
    {
    }
}
