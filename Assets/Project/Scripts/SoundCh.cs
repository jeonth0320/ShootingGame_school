using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCh : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource[] fxPlayer;
    public AudioClip[] fxClip;
    public int playerIndex;
    public enum fx
    {
        fire, effect
    }
    void Start()
    {
        bgm.Play();  
    } 
   

    public void sfxPlayer(fx type)
    {
        switch(type)
        {
            case fx.fire:
                fxPlayer[playerIndex].clip = fxClip[0]; 
                break;
            case fx.effect:
                fxPlayer[playerIndex].clip = fxClip[1];
                break;
        }
        fxPlayer[playerIndex].Play();
        playerIndex = (playerIndex + 1) % fxPlayer.Length;

        //SoundCh.sfxPlayer(fx.fire)
    }
}
