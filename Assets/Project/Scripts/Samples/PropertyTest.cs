using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactorss
{ 

    public int nowHp { get; set; }
    public string name { get; set; }
     
}


public class PropertyTest : MonoBehaviour
{
    private void Start()
    {  
        Charactorss charbase = new Charactorss()
        {
            nowHp = 100,
            name = "PropertyName"
        };

        Debug.Log($"{charbase.name} Ã¼·ÂÀº {charbase.nowHp}");


    }
}
