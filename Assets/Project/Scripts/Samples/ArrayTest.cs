using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    int userExp = 0;
    int exp_1 = 10;
    int exp_2 = 12;
    int exp_3 = 15;
    int exp_4 = 25;
    int exp_5 = 35;
    int exp_6 = 50;
    int exp_7 = 55;
    int exp_8 = 75;
    int exp_9 = 95;
    int exp_10 = 100;
    //배열
    int[] arrayExp = {10, 12, 15, 25, 35, 50, 55, 75, 95, 100 };

    int[] arrayInt = new int[100];
    int[] tarrayInt = new int[101];

    private void Start()
    { 
        for (int i= 0; i<arrayInt.Length; i++)
        {
            tarrayInt[i] = arrayInt[i];
        }
    }


    public GameObject[] cube;


    public int _exp;

    private void Update()
    {
        //삼항 연산자! (조건) ? 참 : 거짓;
        int retExp = (_exp - 1 < 0) ? 0 : (_exp - 1); 

        userExp += arrayExp[_exp - 1]; 
    }

}
