using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    private int scoreCount;
    public Text displayScore;

    void Start()
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
    }

    public void scoreText()
    {
        displayScore.text = "Score: " + scoreCount.ToString();
    }

}
