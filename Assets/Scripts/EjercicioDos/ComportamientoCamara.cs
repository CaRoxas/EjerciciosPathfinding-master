using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ComportamientoCamara : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject Personaje;
    void Start()
    {
        agent = Personaje.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        /* TODO: Lanzar un rayo al pulsar el botón, y modificar el destino de nuestro agente */

        if (Input.GetMouseButtonDown(0))
        {
            Ray pulsacion = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit sitio;
            if (Physics.Raycast(pulsacion, out sitio))
            {
                agent.destination = sitio.point;
            }
        }
    }

}
