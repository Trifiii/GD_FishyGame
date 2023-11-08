using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenScript : MonoBehaviour
{
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
