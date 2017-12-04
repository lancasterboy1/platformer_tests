using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public GameManager gm;
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "score: " + (gm.score).ToString();
	}
}
