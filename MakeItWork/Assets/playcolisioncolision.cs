using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playcolisioncolision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bird"))
        {
            GetComponent<AudioSource>().Play();
        }
            
    }

    

}


