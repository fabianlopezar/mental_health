using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarConNPCs : MonoBehaviour
{
    public GameObject panelTareas;
    public GameObject imagenLetraE;
    public bool panelTareasActivo = false;
    
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            imagenLetraE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Acción que quieres ejecutar cuando se presiona "E"
                panelTareasActivo = !panelTareasActivo;
                panelTareas.SetActive(panelTareasActivo);
                Debug.Log("Se ha presionado la tecla E");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
            imagenLetraE.SetActive(false);
            panelTareas.SetActive(false);
        
    }
}
