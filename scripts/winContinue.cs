// Kristina Russell - December 11th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winContinue : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;
    public GameObject completedBackground;
    
    // make sure everything is hidden on start
    void Start() {
        winText.SetActive(false);
        loseText.SetActive(false);
        completedBackground.SetActive(false);
    }

    // when the user presses the continue button, this brings them back to the map
    public void continueGameDone () {
        SceneManager.LoadScene("map");
    }
}
