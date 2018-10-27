using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {

    public float playerSpeed, rotateSpeedX;

    private float moveHorizontal, moveVertical, rotateHorizontal;


	void Update () {



        //player movement (keyboard)
        moveHorizontal = (Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
        moveVertical = (Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
        transform.Translate(moveHorizontal, 0f, moveVertical);

        //player rotation (mouse)
        rotateHorizontal = (Input.GetAxis("Mouse X") * rotateSpeedX * Time.deltaTime);
        if (!Input.GetMouseButton(0))                                                   //don't move if slider is being used
            transform.Rotate(0f, rotateHorizontal, 0f);

    }


}
