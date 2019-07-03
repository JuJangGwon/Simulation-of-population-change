using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(Singleton)) as Singleton;

            if (instance == null)
                Debug.Log("no instance");

            return instance;
        }
    }
    public int[] buildlevel;
    public int[] needbuildmoney;
    public int GoLD = 10000000;
    public int stf = 1;
    public bool stop = false;
    public int[] DISTINCT;
}   



