using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 5.0f; // Velocidad de rotación de la cámara

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;

        // Rotar la cámara horizontalmente basado en la entrada del ratón
        transform.Rotate(Vector3.up, mouseX);
    }
}
