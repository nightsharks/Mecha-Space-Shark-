using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int Score = 0;

    public void Start()
    {
        showScore();
    }

    public string showScore()
    {
        return Score.ToString(); 
    }

    public void scoreCounter()
    {
        Score = Score++;
    }
}
