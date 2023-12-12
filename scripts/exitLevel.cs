// Kristina Russell - December 11th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    // THIS SHOULD BE USED FOR THE BACK BUTTON IN EVERY LEVEL

public class exitLevel : MonoBehaviour
{
    // loads the map scene when the button is pressed
    public void backToMap() {
        SceneManager.LoadScene("map");
    }
}
