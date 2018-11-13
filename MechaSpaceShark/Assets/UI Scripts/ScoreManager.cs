using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private highestScore highestScores;
    private highestDistance highestDistance;

    void Start()
    {
        LoadPlayerProgress();
        LoadPlayerProgressDistance();
    }

    public void SubmitNewPlayerScore(int newScore)
    {
        if (newScore > highestScores.highScores)
        {
            highestScores.highScores = newScore;
            SavePlayerProgress();            
        }

    }

    public void SubmitNewPlayerDistance(int newDistance)
    {
        if (newDistance > highestDistance.highDistance)
        {
            highestDistance.highDistance = newDistance;
            SavePlayerProgressDistance();
        }
    }

    public int GetHighestPlayerScore()
    {
        return highestScores.highScores;
    }

    public int GetHighestPlayerDistance()
    {
        return highestDistance.highDistance;
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", highestScores.highScores);
        PlayerPrefs.Save();
    }

    private void SavePlayerProgressDistance()
    {
        
        PlayerPrefs.SetInt("highestDistance", highestDistance.highDistance);
        PlayerPrefs.Save();
    }

    private void LoadPlayerProgress()
    {
        highestScores = new highestScore();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            highestScores.highScores = PlayerPrefs.GetInt("highestScore");
            Debug.Log(" score key exists");
            Debug.Log(highestScores.highScores);
        }

    }

    private void LoadPlayerProgressDistance()
    {

        highestDistance = new highestDistance();

        if (PlayerPrefs.HasKey("highestDistance"))
        {
            highestDistance.highDistance = PlayerPrefs.GetInt("highestDistance");
            Debug.Log(" distance key exists");
            Debug.Log(highestDistance.highDistance);
        }
    }
}
