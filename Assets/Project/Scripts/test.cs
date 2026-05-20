using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
     
    void Start()
    {
        GameObject gameManagerObj = GameObject.Find("GameManager"); 
        ScoreManager scoreManager = gameManagerObj.GetComponent<ScoreManager>();

        scoreManager.setScore(scoreManager.getScore() + 1);
 //       scoreManager.NowScore = scoreManager.NowScore + 1;

        Debug.Log("nowScore : " + scoreManager.getScore());
     //   Debug.Log("NowScore : " + scoreManager.NowScore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
