using UnityEngine;
using System.Collections;

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
