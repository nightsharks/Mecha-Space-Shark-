﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public GameObject EndMenuUI;
    public GameObject InGameUI;

    public Text FinalScore;
    public Text FinalDistance;

    public Text HighScore;
    public Text HighDistance;

    public ScoreManager scoreboard;

    public void Start()
    {
        scoreboard = FindObjectOfType<ScoreManager>();
        EndMenuUI.SetActive(false);
    }

    void Update()
    {

        if (Obstacle.CollideWithAsteroid)
        {
            EndMenuUI.SetActive(true);
            Time.timeScale = 0f;
            scoreboard.SubmitNewPlayerScore (playerController.finalScore, Distance.distanceNumber);
            // line 32 is calling null reference
            FinalScore.text = "Final Score: " + playerController.finalScore.ToString();
            FinalDistance.text = Distance.otherUIText.ToString();
      
            HighScore.text = "High Score: " + scoreboard.GetHighestPlayerScore().ToString();
            HighDistance.text = "Farthest Distance: " + scoreboard.GetHighestPlayerDistance().ToString();
            
            InGameUI.SetActive(false);
        }

    }
}
