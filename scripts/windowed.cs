// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowed : MonoBehaviour
{
    // on button press, fullscreen state will be turned off, putting it into windowed mode
    public void windowSC() {
        Screen.fullScreen = false;
    }
}
