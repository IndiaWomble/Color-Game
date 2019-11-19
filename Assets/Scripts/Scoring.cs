using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    int score = 0;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            score++;
            scoreText.text = "Score : " + score;
        }
    }
}
