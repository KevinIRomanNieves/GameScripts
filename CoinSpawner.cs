using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject Coin;
    public int rate;
    float spawnRate;
    public Transform airspawn;

    float nextSpawn = 0f;

    int whatToSpawn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 3);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:

                    Coin.gameObject.SetActive(true);
                    Instantiate(Coin, transform.position, Quaternion.identity);

                    break;

                case 2:
                    Coin.gameObject.SetActive(true);
                    Instantiate(Coin, airspawn.position, airspawn.rotation);

                    break;


            }
            //rate = Random.Range(1, rate);
            spawnRate = Random.Range(1, rate);
            nextSpawn = Time.time + spawnRate;

        }

    }
}
