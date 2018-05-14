using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;
	// Use this for initialization
	void Start ()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {   
            //lock paddle and ball
            this.transform.position = paddle.transform.position + paddleToBallVector;
            //wait for mouse to be clicked
            if (Input.GetMouseButtonDown(0))
            {
                print("Mouse clicked, launch ball");
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
	}
}
