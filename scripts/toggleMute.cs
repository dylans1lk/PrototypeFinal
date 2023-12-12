// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class toggleMute : MonoBehaviour
{
    // get the 2 image objects
    // toggle val for volume
    public Image notMuted;
    public Image isMuted;

    private void Update() {
    /*===========================
    
    IMPLEMENT VOLUME TOGGLE HERE

    ===========================*/
    }

    // toggle the isMuted button object on and the other off so the check mark button is replaced by the x button
    public void nMuted() {
        isMuted.gameObject.SetActive(true);
        notMuted.gameObject.SetActive(false);
    }

    // toggle the notMuted button object on and the other off so the x button is replaced by the check mark button
    public void yMuted() {
        notMuted.gameObject.SetActive(true);
        isMuted.gameObject.SetActive(false);
    }
}
