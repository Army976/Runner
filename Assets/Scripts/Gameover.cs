using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obs")
        {
            
            Application.LoadLevel("runner");

        }
    }

   
}
