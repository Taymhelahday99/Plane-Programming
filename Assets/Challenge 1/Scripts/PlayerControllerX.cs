using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 0.5f;
    private float rotationSpeed= 50.0f;
    private float verticalInput;

    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
