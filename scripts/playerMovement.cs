// Kristina Russell - November 17th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Collider2D playerCollider;
    public Animator playerAnimate;
    Vector2 movement;
    private float mSpeed = 4f;
    public bool inTileZone;
    

    // Start is called before the first frame update
    private void Start() {
        // get component once so we dont waste time getting it
        playerRB = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        inTileZone = false;
    }

    // Update is calsled once per frame
    private void Update() {
        movement.x= Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Updates values for the player animation nodes to use
        // speed is being set to the length of the movement vector (aka magnitude)
        // sqr version is more optimized than sqrtinng the mag yourself :D
        playerAnimate.SetFloat("Horizontal", movement.x);
        playerAnimate.SetFloat("Vertical", movement.y);
        playerAnimate.SetFloat("Speed", movement.sqrMagnitude);

    }
    // having the movement in fixed update helps minimize movement based bugs
    private void FixedUpdate() {
        // change the player position by the movement being inputted (multed by 6 here) and a decay time
        playerRB.MovePosition(playerRB.position + movement * mSpeed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.E) && inTileZone) {
            SceneManager.LoadScene("level_1");
        }

    }

    // This is a Unity function that we're editing the functionallity of
    // This is for trigger type collision boxes to detect eachother
    void OnTriggerEnter2D(Collider2D objCollided) {
        if (objCollided.CompareTag("interactable")) {
            inTileZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("interactable")) {
            inTileZone = false;
        }
    }



}
/*
    USEFUL FUNCTIONS THAT ARE NO LONGER BEING USED

        for a minigame with jump (aka we have a side view with ground below the player and gravity

        playerRB.velocity = new Vector2(moveX * 5f, playerRB.velocity.y);
        playerRB.velocity = new Vector2(playerRB.velocity.x, moveY * 5f);
        if (Input.GetButtonDown(<Desired button goes here>)){
            playerRB.velocity = new Vector2(0, 0); <--- change which velocity gets edited (x, y)
        }


    This was originally me trying to use Raycasting to detect the tiles...

    private void goToLevel() {
        RaycastHit2D checkInfront = Physics2D.Raycast(transform.position, transform.up, 1f);

        if (checkInfront.collider != null && checkInfront.collider.CompareTag("interactable")) {
            Debug.Log
            SceneManager.LoadScene("level_1");
        }
    }


*/
