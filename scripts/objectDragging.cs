// Kristina Russell - December 11th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDragging : MonoBehaviour {
    private bool isDragging = false;
    Vector3 droppedLocation;
    private Vector3 startPosition;
    private scoreKeeper score;

    private void Start () {
        score = FindObjectOfType<scoreKeeper>();
    }

    private void OnMouseDown() {
        isDragging = true;
        startPosition = transform.position;
    }

    // transform the object to be in the location the mouse is moving across
    private void OnMouseDrag() {
        if (isDragging) {
            droppedLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(droppedLocation.x, droppedLocation.y, startPosition.z);
        }
    }

    // when the user lets go, update the drag state
    private void OnMouseUp() {
        isDragging = false;
    }

    // checks the collisions for the correct/incorrect barrel
    private void OnCollisionEnter2D(Collision2D collision) {
        // in the case the object collides with a barrel, 
        if (collision.gameObject.CompareTag("barrel")) {
            if (collision.gameObject.name == "barrel_INTEGER" && (gameObject.name == "obj_5" || gameObject.name == "obj_23")) {
                Debug.Log("Correct bin");
                score.UpdateScore(true);
            }
            if (collision.gameObject.name == "barrel_CHARACTER" && (gameObject.name == "obj_A" || gameObject.name == "obj_B")) {
                Debug.Log("Correct bin");
                score.UpdateScore(true);
            }
            if (collision.gameObject.name == "barrel_INTEGER" && !(gameObject.name == "obj_5" || gameObject.name == "obj_23")){
                Debug.Log("Wrong bin");
            }
            if (collision.gameObject.name == "barrel_CHARACTER" && !(gameObject.name == "obj_A" || gameObject.name == "obj_B")){
                Debug.Log("Wrong bin");
            }
            // this destroys the object and checks if all of the objects
            // are gone and if the game is over
            Destroy(gameObject);
            score.isGameComplete();
        }
    }
}


