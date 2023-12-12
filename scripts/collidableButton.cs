// Kristina Russell - November 18th, 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // THIS FILE IS UNUSED. I HAVE TAKEN OUT COLLIDABLE OBJECTS FOR NOW

public class collidableButton : MonoBehaviour
{
    private Collider2D objCollider;
    [SerializeField] private ContactFilter2D objFilter;
    private List<Collider2D> collidedWith = new List<Collider2D>(1);

    protected virtual void Start() {
        objCollider = GetComponent<Collider2D>();
    }

    protected virtual void Update() {
        // objCollider.OverlapCollider(objFilter, collidedWith);
        // for(var i=0; i < collidedWith.Count; i++){
        //     collisionHappened(i.gameObject);
        // }
    }

    protected virtual void collisionHappened(GameObject objectHit){

    }

}
