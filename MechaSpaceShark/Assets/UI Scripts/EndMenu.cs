using System.Collections;
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
           
            FinalScore.text = "Final Score: " + playerController.finalScore.ToString();
            FinalDistance.text = Distance.otherUIText.ToString();

            scoreboard.SubmitNewPlayerScore(playerController.finalScore);
            scoreboard.SubmitNewPlayerDistance(Distance.distanceInt);

            HighScore.text = "High Score: " + scoreboard.GetHighestPlayerScore().ToString();
            HighDistance.text = "Farthest Distance: " + scoreboard.GetHighestPlayerDistance().ToString();
         
            InGameUI.SetActive(false);
        }

    }
}
