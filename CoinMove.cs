using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour {

    // Use this for initialization
    public static int coins;
    public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        RemoveCoin();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            coins += 1;
            PlayerPrefs.SetInt("Highscore", coins);
            Destroy(gameObject);
            
        }
        else
            Destroy(gameObject,1f);
    }
    void RemoveCoin()
    {
        Destroy(gameObject, 5f);
    }
}
