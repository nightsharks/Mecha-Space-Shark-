using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int scoreCount = 0;
    public Text displayScore;

    void Update()
    {
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 200.0f;
        var x = Time.deltaTime * 300.0f;

        transform.Translate(x, y, 0);
    }

    public void scoreText()
    {
        displayScore.text = "Score: " + scoreCount.ToString();
    }

}
