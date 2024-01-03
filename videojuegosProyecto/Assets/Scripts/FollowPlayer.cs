using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float smoothSpeed = 0.125f; // Velocidad de seguimiento
    public Vector3 offset; // Offset de la c�mara respecto al jugador

    public float rotateSpeed = 5.0f; // Velocidad de rotaci�n de la c�mara

    void LateUpdate()
    {
        // Calcula la rotaci�n actual de la c�mara
        float desiredAngle = player.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        // Calcula la posici�n deseada de la c�mara sumando el offset al jugador
        Vector3 desiredPosition = player.position - (rotation * offset);

        // Calcular una transici�n suave hacia la nueva posici�n de la c�mara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Establecer la nueva posici�n de la c�mara
        transform.position = smoothedPosition;

        // Orientar la c�mara hacia el jugador
        transform.LookAt(player);
    }
}
