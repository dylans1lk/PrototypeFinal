// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// THIS FUNCTION SHOULD ONLY BE USED IN THE OPTIONS SCREEN THAT IS ACCESSED FROM THE START SCREEN

public class backStart : MonoBehaviour
{
    // load the start screen when the button is pressed
    public void back(){
        SceneManager.LoadScene("startScreen");
    }
}
