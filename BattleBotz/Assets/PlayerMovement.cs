using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public Vector3 OriginPosition;
    private float PlayerX;
    private float PlayerY;
    private bool Moving = false;
	// Use this for initialization
	void Start () {
        transform.position = OriginPosition;
        PlayerX = transform.position.x;
        PlayerY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        Moving = false;



        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) && Moving == false) {
            PlayerX += speed;
            Debug.Log("move");
            Moving = true;
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) && Moving == false)
        {
            PlayerY -= speed;
            Debug.Log("move");
            Moving = true;
        }

        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow) && Moving == false)
        {
            PlayerX -= speed;
            Debug.Log("move");
            Moving = true;
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) && Moving == false)
        {
            PlayerY += speed;
            Debug.Log("move");
            Moving = true;
        }

        transform.position = new Vector3(PlayerY, PlayerX, 0);

    }
}
