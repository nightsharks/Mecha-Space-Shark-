using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int scoreCount;
    public Text displayScore;
    public static int finalScore = 0;

    void OnEnable()
    {
        scoreCount = 0;
        scoreText();      
    }
    void Update()
    {
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 200.0f;
        var x = Time.deltaTime * 300.0f;

        transform.Translate(x, y, 0);

        if(Trigger.CollideWithFood)
        {
            scoreCount++;
            scoreText();
        }

        if(Trigger.CollideWithRock)
        {
            finalScore = scoreCount;
            deleteScore();
        }
    }

    public void scoreText()
    {
        displayScore.text = "Score: " + scoreCount.ToString();
    }

    public void deleteScore()
    {
        displayScore.text = "";
    }

}
