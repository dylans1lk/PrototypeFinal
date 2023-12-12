// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // hitting the start game button brings us to the character customize page
    public void gameStart(){
        // Debug.Log("!!! -----> START BUTTON IS EXECUTING <----- !!!");
        SceneManager.LoadScene("customize");
    }
}
