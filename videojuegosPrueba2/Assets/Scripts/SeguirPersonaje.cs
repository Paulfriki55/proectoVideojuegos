using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del personaje que seguir� la c�mara
    public Vector3 offset = new Vector3(0f, 3f, -10f); // La posici�n relativa de la c�mara al personaje
    public float velocidadRotacion = 3.0f; // Velocidad de rotaci�n de la c�mara

    public float limiteSuperior = 40f; // L�mite superior de rotaci�n en el eje Y
    public float limiteInferior = -40f; // L�mite inferior de rotaci�n en el eje Y

    private float rotacionX = 0.0f;
    private float rotacionY = 0.0f;

    void Update()
    {
        if (objetivo != null)
        {
            // Configurar la posici�n de la c�mara con el offset deseado
            Vector3 posicionDeseada = objetivo.position + offset;
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);

            // Obtener los movimientos del mouse en los ejes horizontal y vertical
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Aplicar los movimientos del mouse para rotar la c�mara alrededor del personaje
            rotacionX += mouseX * velocidadRotacion;
            rotacionY -= mouseY * velocidadRotacion;

            // Limitar la rotaci�n en el eje Y dentro de los l�mites establecidos
            rotacionY = Mathf.Clamp(rotacionY, limiteInferior, limiteSuperior);

            // Aplicar la rotaci�n a la c�mara
            transform.eulerAngles = new Vector3(rotacionY, rotacionX, 0.0f);
        }
    }
}
