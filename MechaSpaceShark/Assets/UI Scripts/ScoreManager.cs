using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private highestScore highestScores;
    private highestScore highestDistance;

    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        LoadPlayerProgress();
    }

    public void SubmitNewPlayerScore(int newScore, float newDistance)
    {
        if (newScore > highestScores.highScores)
        {
            highestScores.highScores = newScore;
            SavePlayerProgress();
            Debug.Log("progress1");
        }

        if (newDistance > highestDistance.highDistance)
        {
            highestDistance.highDistance = newDistance;
            SavePlayerProgress();
            Debug.Log("progress");
        }
    }
    public int GetHighestPlayerScore()
    {
        return highestScores.highScores;
    }

    public float GetHighestPlayerDistance()
    {
        return highestDistance.highDistance;
    }
    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", highestScores.highScores);
        PlayerPrefs.SetFloat("highestDistance", highestDistance.highDistance);
    }

    private void LoadPlayerProgress()
    {
        highestScores = new highestScore();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            highestScores.highScores = PlayerPrefs.GetInt("highestScore");
        }

        highestDistance = new highestScore();

        if (PlayerPrefs.HasKey("highestDistance"))
        {
            highestDistance.highDistance = PlayerPrefs.GetInt("highestDistance");
        }
    }
}
