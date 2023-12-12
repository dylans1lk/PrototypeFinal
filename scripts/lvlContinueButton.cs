// Kristina Russell - December 11th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlContinueButton : MonoBehaviour {
    public GameObject instructionsText;
    public GameObject instructionsBackground;

    void Start() {
        instructionsText.SetActive(true);
        instructionsBackground.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void contGame() {
        instructionsText.SetActive(false);
        instructionsBackground.SetActive(false);
        Time.timeScale = 1f;
    }
}
