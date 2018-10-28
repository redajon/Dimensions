using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_controller : MonoBehaviour {

    public float rotateSpeedY;                                          // user-defined rotation speed

    private float rotationY = 0f;


    private void Awake() {

        Cursor.lockState = CursorLockMode.Confined;                     // keep mouse cursor inside window

    }


    void Update () {

        float vertical = Input.GetAxis("Mouse Y");                      // get 'Y' axis movement from mouse

        rotationY = (vertical * rotateSpeedY * Time.deltaTime);         // adjust for user-defined rotation speed

        Quaternion localRotation = Quaternion.Euler(rotationY, 0, 0);   // convert to Quaternion

        transform.rotation *= localRotation;                            // move GameObject

    }
}
