using UnityEngine;
using System.Collections;

//Source file name:SpawnGems
//Author’s name:Pranoy Anil
//Last Modified by:Pranoy Anil
//Date last Modified:1/3/16 
//Program description: GemHunt - Assignment 02

public class SpawnGems : MonoBehaviour {

    public Transform[] gemSpawns;
    public GameObject gem;

    // Use this for initialization
    void Start()
    {

        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < gemSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
                Instantiate(gem, gemSpawns[i].position, Quaternion.identity);
        }
    }
}
