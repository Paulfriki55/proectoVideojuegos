using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float smoothSpeed = 0.125f; // Velocidad de seguimiento
    public Vector3 offset; // Offset de la cámara respecto al jugador

    public float rotateSpeed = 5.0f; // Velocidad de rotación de la cámara

    void LateUpdate()
    {
        // Calcula la rotación actual de la cámara
        float desiredAngle = player.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        // Calcula la posición deseada de la cámara sumando el offset al jugador
        Vector3 desiredPosition = player.position - (rotation * offset);

        // Calcular una transición suave hacia la nueva posición de la cámara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Establecer la nueva posición de la cámara
        transform.position = smoothedPosition;

        // Orientar la cámara hacia el jugador
        transform.LookAt(player);
    }
}
