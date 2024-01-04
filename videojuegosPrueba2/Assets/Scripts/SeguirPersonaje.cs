using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del personaje que seguirá la cámara
    public Vector3 offset = new Vector3(0f, 3f, -10f); // La posición relativa de la cámara al personaje
    public float velocidadRotacion = 3.0f; // Velocidad de rotación de la cámara

    public float limiteSuperior = 40f; // Límite superior de rotación en el eje Y
    public float limiteInferior = -40f; // Límite inferior de rotación en el eje Y

    private float rotacionX = 0.0f;
    private float rotacionY = 0.0f;

    void Update()
    {
        if (objetivo != null)
        {
            // Configurar la posición de la cámara con el offset deseado
            Vector3 posicionDeseada = objetivo.position + offset;
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);

            // Obtener los movimientos del mouse en los ejes horizontal y vertical
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Aplicar los movimientos del mouse para rotar la cámara alrededor del personaje
            rotacionX += mouseX * velocidadRotacion;
            rotacionY -= mouseY * velocidadRotacion;

            // Limitar la rotación en el eje Y dentro de los límites establecidos
            rotacionY = Mathf.Clamp(rotacionY, limiteInferior, limiteSuperior);

            // Aplicar la rotación a la cámara
            transform.eulerAngles = new Vector3(rotacionY, rotacionX, 0.0f);
        }
    }
}
