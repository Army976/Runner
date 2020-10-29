using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveLeftRight = -Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveLeftRight);

        rb.AddForce(movement * 15);
        
    }

}