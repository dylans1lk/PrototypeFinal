// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // using bool to hold game paused state
    public static bool isGamePaused = false;

    // gameobjects to hold the pauseMenu object and the optionsMenu object
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;

    // check for esc pressed, then check state of game (via bool) in order to know which function to call
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isGamePaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    // hides the pause menu pannel, resumes time/movements, updates game state to unpaused
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    // show the pause menu pannel, pauses time/movements, updates game state to paused
    public void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    // unpauses time/movements, sets state to unpaused, loads the start screen
    public void Menu(){
        Time.timeScale = 1f;
        isGamePaused = false;
        SceneManager.LoadScene("startScreen");
    }

    // quits the applicaiton
    public void Exit(){
        Application.Quit();
    }

    // opens the options pannel as well as hiding the pause menu
    public void options() {
        optionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);

    }

    // turns fullscreen mode on
    public void fullscreen() {
        Screen.fullScreen = true;
    }

    // turns the windowed mode on
    public void windowed() {
        Screen.fullScreen = false;
    }

    // once done with the options menu, hide the options menu and show the pause menu
    public void backToPaused() {
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    // these functions will change the volume to preset numbers (e.g. 25%, 50%, 100%)
    public void volumeLow() {

        /*==============================

            IMPLEMENT VOLUME SETTINGS

        ==============================*/

    }
    public void volumeMed() {

        /*==============================

            IMPLEMENT VOLUME SETTINGS

        ==============================*/

    }

    public void volumeHigh() {

        /*==============================

            IMPLEMENT VOLUME SETTINGS

        ==============================*/

    }
    
}
