using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToExit : MonoBehaviour
{
    void Update()
    { 
        // ESC 키로도 종료 가능하게 (옵션)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}