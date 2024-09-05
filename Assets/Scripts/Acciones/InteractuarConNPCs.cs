using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarConNPCs : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Acción que quieres ejecutar cuando se presiona "E"
                Debug.Log("Se ha presionado la tecla E");
            }
        }
    }
}
