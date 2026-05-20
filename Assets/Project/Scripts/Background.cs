using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material materialBG;
    public float scrollSpd = 0.2f;

    private void Update()
    {
        Vector2 direct = Vector2.up;
        materialBG.mainTextureOffset += direct * scrollSpd * Time.deltaTime;
    }


}
