using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Movimiento : MonoBehaviour
{
    Rigidbody rb;
    NavMeshAgent agent;
    public Transform presa;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = presa.position;
    }
    private void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.tag == "Player")
        {
            Destroy(GameObject.Find("Heroe"));
            Time.timeScale = 0;
        }
    }
}
