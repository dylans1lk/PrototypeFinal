// Kristina Russell - December 11th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreKeeper : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI scoreboard;
    [SerializeField] private GameObject bundle;
    private int currScore;
    private int maxScore;

    public GameObject winText;
    public GameObject loseText;
    public GameObject lvlCompleteBackground;


    // make sure everything is hidden on startup
    // get count of how many objects are avalible
    private void Start() {
        winText.SetActive(false);
        loseText.SetActive(false);
        lvlCompleteBackground.SetActive(false);
        maxScore = bundle.transform.childCount;
        currScore = 0;
        UpdateScoreText();
    }

    // adds to the score when something sends a correct bin signal
    public void UpdateScore(bool correctBin) {
        if (correctBin) {
            currScore++;
            UpdateScoreText();
        }
    }

    // updates the scoreboard
    void UpdateScoreText()
    {
        scoreboard.text = $"Score:\n{currScore}/{maxScore}";
    }

    // checks the score and displays an endgame message dependant on that
    public void isGameComplete () {
        if (bundle.transform.childCount == 1){
            Debug.Log("level is over");
            if (currScore == maxScore) {
                Debug.Log("We won!");
                winText.SetActive(true);
                lvlCompleteBackground.SetActive(true);
                return;
            }
            if (currScore < maxScore){
                Debug.Log("WE LOST!");
                loseText.SetActive(true);
                lvlCompleteBackground.SetActive(true);
            }
        }
        else {
            Debug.Log("Game is not yet over, " + bundle.name + " has "
            + bundle.transform.childCount + " objects left.");
        }
    }
}
