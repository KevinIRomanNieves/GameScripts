using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

	// Use this for initialization
	public Text score;
	

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		score.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();

	}
		
}
