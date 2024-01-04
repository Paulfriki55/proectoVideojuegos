using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Cambiar al nombre de la escena del bosque
    public string escenaBosque;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el collider es el jugador
        {
            SceneManager.LoadScene(escenaBosque); // Cargar la escena del bosque
        }
    }
}
