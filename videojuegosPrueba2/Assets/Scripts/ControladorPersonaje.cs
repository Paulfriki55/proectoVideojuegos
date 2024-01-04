using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float fuerzaSalto = 10f;
    public LayerMask capaSuelo;
    public float distanciaRaycast = 0.1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, -Vector3.up, distanciaRaycast, capaSuelo))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Aplicar fuerza de salto si el personaje está en el suelo
                rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            }
        }
    }
}
