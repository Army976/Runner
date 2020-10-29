using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour
{

    private Rigidbody rb;

    void Start()
    {
        rb =GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveForward = -1f;

        Vector3 movement = new Vector3(moveForward, 0, 0.0f);

        rb.AddForce(movement * 2);
    }
}