using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Rigidbody2D playerRigidBody2D; 
    public float movePlayerHorizontal;
    public Vector2 movement;

    public float speed = 4.0f;

    void Awake()
    {
        playerRigidBody2D = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
    }

    // Update is called once per frame
    void Update () {

        movePlayerHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(movePlayerHorizontal, y: 0);

        playerRigidBody2D.velocity = movement * speed;
		
	}
}
