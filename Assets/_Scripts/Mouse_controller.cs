using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_controller : MonoBehaviour {

    public float rotateSpeedY;

    private float rotationY = 0f;


    private void Awake() {

        Cursor.lockState = CursorLockMode.Confined;                     // keep mouse cursor inside window

    }


    void Update () {

        float vertical = Input.GetAxis("Mouse Y");

        rotationY = (vertical * rotateSpeedY * Time.deltaTime);

        Quaternion localRotation = Quaternion.Euler(rotationY, 0, 0);

        transform.rotation *= localRotation;

    }
}
