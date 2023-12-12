// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    // THIS SHOULD BE USED FOR THE CONTINUE BUTTON IN THE CUSTOMIZATION MENU

public class continueButton : MonoBehaviour
{
    // load the map scene when the button is pressed
    public void continueToMap(){
        // Debug.Log("!!! -----> OPTIONS BUTTON IS EXECUTING <----- !!!");
        SceneManager.LoadScene("map");
    }
}