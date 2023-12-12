// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionsMenu : MonoBehaviour
{
    // load the options menu scene when the button is pressed
    public void openOptions(){
        // Debug.Log("!!! -----> OPTIONS BUTTON IS EXECUTING <----- !!!");
        SceneManager.LoadScene("optionsMenu");
    }
}