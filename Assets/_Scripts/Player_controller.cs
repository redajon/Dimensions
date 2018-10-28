using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {

    public float playerSpeed, rotateSpeed;                                              // user-defined movement speed

    private float moveHorizontal, moveVertical, rotateHorizontal;


	void Update () {



        //player movement (keyboard)
        moveHorizontal = (Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);  // keyboard (horizontal)

        moveVertical = (Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);      // keyboard (vertical)

        transform.Translate(moveHorizontal, 0f, moveVertical);                          // move GameObject

        //player rotation (mouse)
        rotateHorizontal = (Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);   // mouse (horizontal)

        if (!Input.GetMouseButton(0))                                                   //don't move if slider is being used
            transform.Rotate(0f, rotateHorizontal, 0f);

    }


}
