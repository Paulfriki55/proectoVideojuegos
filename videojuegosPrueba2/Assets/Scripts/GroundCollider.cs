using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public

class

GroundCollider : MonoBehaviour
{
    public LayerMask groundLayer;
    public float minHeight;
    public float maxHeight;

    void OnTriggerEnter(Collider other)
    {
        // Si el objeto que entra en contacto es un s�lido y est� por debajo de la altura m�xima del suelo, lo colocamos en la posici�n correcta.
        if (other.gameObject.layer == groundLayer && other.transform.position.y < maxHeight)
        {
            other.transform.position = new Vector3(other.transform.position.x, maxHeight, other.transform.position.z);
        }
    }
}