using UnityEngine;
using System.Collections;

//Source file name:PlatformFall
//Author’s name:Pranoy Anil
//Last Modified by:Pranoy Anil
//Date last Modified:1/3/16 
//Program description: GemHunt - Assignment 02

public class PlatformFall : MonoBehaviour {

    public float fallDelay = 1f;


    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        rb2d.isKinematic = false ;
    }
}
