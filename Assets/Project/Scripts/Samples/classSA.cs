using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classSA : MonoBehaviour
{ 

    void Start()
    {
        StaticTest t1 = new StaticTest();
        t1.lovebug = 10;
        StaticTest.num = 10;


        StaticTest t2 = new StaticTest();
        t2.lovebug = 20;
        StaticTest.num = 20;

        Debug.Log($"{t1.lovebug} / {StaticTest.num}");
        Debug.Log($"{t2.lovebug} / {StaticTest.num}");
    }
     
}
