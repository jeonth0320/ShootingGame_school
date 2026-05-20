using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    //배경음
    public AudioSource bgm;
    //음악 재생하는 아이(3명)
    public AudioSource[] fxPlayer;
    //음원
    public AudioClip[] fxClip;
    //음악을 재생하는 아이 번호 (0~2, 3명)
    public int playerIndex = 0; 
  
      
    public enum fx
    {
        fire, effect
    }
     
    public void FxPlayer(fx type)
    {
        switch(type)
        {
            case fx.fire:
                //음악을 재생하는 첫번째 아이에게  첫번째 음원을 연결
                fxPlayer[playerIndex].clip = fxClip[0];
                break;
            case fx.effect:
                //음악을 재생하는 두번째 아이에게  두번재 음원을 연결
                fxPlayer[playerIndex].clip = fxClip[1];
                break;

        }

        fxPlayer[playerIndex].Play();

        playerIndex = (playerIndex + 1) % fxPlayer.Length;
    }





    private void Start()
    {
        bgm.Play(); 
    }
}
