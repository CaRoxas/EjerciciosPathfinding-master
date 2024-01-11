using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHeroe : MonoBehaviour
{
    Rigidbody rb;
    float movX, movZ;
    float McQueen = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 Velocidad = new Vector3(movX * McQueen, rb.velocity.y, movZ * McQueen);
        rb.velocity = Velocidad;
    }
}
