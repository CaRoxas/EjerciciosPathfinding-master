using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPuntos : MonoBehaviour
{
    public Vector3[] listaVectores = new Vector3[4];
    public NavMeshAgent agente;
    public Transform destino;
    static int actual = 0;
   
    // Start is called before the first frame update
    private void Start()
    {
        /* TODO: Crear la lista de puntos (se puede hacer por código o desde la UI*/

        /* TODO: Establecer el primer punto como destino */
        agente = GetComponent<NavMeshAgent>();
        agente.destination = listaVectores[actual];

    }

    // Update is called once per frame
    void Update()
    {
        /* El algoritmo es algo así:
         *  1 - Si hemos llegado al destino (es decir, la x y z de mi transform es igual al destino establecido en el agente)
         *  2 - Busco cual es el siguiente punto, y lo establezco como destino. ¿Qué pasa si hemos llegado al último punto?
         */
        // transform.position -> posicion personaje
        // agent.destination -> destino
        if (transform.position.x == agente.destination.x && transform.position.z == agente.destination.z)
        {
            actual++;
            if (actual > 4)
            {
                actual = 0;
            }
            agente.destination = listaVectores[actual];
        }
    }
}
