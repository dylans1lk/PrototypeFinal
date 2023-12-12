// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT CONTROLS THE CAMERA MOVEMENT. I MAY OR MAY NOT END UP USING THIS FOR EVERY SCRIPT

public class cameraFollowOffset : MonoBehaviour
{
    // we need to use a vector 3 here due to camera node's nature of sitting -10f away from the canvas on the Z axis
    // transitionTime is the time it takes the camera to recenter
    // we need something to calculate the speed occuring in that transition
    private Vector3 cOffset = new Vector3(0f, 0f, -10f);
    private float transitionTime = 0.50f;
    private Vector3 speed = Vector3.zero;

    // Serializing this so we dont have to leave it as a public variable that could accidentally be edited
    // akak minmizing accidental access/misusage that could case a bug
    // https://forum.unity.com/threads/when-to-use-serializefield-and-why.184687/
    [SerializeField] private Transform camFollowingTarg;

    void Update()
    {
        // using the camera position with the added offset to utilize the SmoothDamp keyword
        // SmoothDamp takes the curr camera position, give it the desired end position,
        // and calculates the speed to transform everything based on the transitionTime 
        Vector3 endPos = camFollowingTarg.position + cOffset;
        transform.position = Vector3.SmoothDamp(transform.position, endPos, ref speed, transitionTime);
    }
}
