using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonClass : MonoBehaviour
{
    public static SingleTonClass Instance = null;
     
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    public static void a()
    {

    }
}
