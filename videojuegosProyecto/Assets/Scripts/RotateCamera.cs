using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 5.0f; // Velocidad de rotaci�n de la c�mara

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;

        // Rotar la c�mara horizontalmente basado en la entrada del rat�n
        transform.Rotate(Vector3.up, mouseX);
    }
}
