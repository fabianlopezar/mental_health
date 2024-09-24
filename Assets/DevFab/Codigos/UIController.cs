using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject inventario;
    public bool inventarioActivado;
    void Start()
    {
        inventarioActivado = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ManejadorInventario()
    {
        inventarioActivado = !inventarioActivado;
        inventario.SetActive(inventarioActivado);
    }

}
