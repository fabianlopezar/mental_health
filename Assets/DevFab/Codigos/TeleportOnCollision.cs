using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public Transform teleportTarget; // Punto al que deseas teletransportar el objeto
    private bool canTeleport = false; // Bandera para saber si el objeto está en posición de ser teletransportado
    private GameObject collidingObject; // El objeto que colisiona

    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que colisiona es el correcto (puedes verificar la etiqueta o el nombre)
        if (other.CompareTag("Player")) // Cambia "Player" por la etiqueta del objeto
        {
            canTeleport = true;
            collidingObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reseteamos la bandera cuando el objeto sale del trigger
        if (other.CompareTag("Player"))
        {
            canTeleport = false;
            collidingObject = null;
        }
    }

    private void Update()
    {
        // Si el jugador presiona "E" y puede teletransportarse
        if (canTeleport && Input.GetKeyDown(KeyCode.E))
        {
            // Cambia la posición del objeto colisionado al destino
            collidingObject.transform.position = teleportTarget.position;
            Debug.Log("Objeto teletransportado.");
        }
    }
}
