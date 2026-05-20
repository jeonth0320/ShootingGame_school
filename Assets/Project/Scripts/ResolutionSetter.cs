using UnityEngine;
using static TreeEditor.TreeGroup;

public class ResolutionSetter : MonoBehaviour
{
    public int Width = 720;
    public int Height = 1440;
    public bool Disabled = false;
    
    private void Start()
    { 
        Screen.SetResolution(Width, Height, Disabled);
    }
}



