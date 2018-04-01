using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public GameObject player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Destroy(player);
        }
    }
}
