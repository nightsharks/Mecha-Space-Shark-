using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int scoreCount = 0;
    public Text displayScore;

    void Update()
    {
        var x = Input.GetAxis("Vertical") * Time.deltaTime * 200.0f;
        var y = Time.deltaTime * 300.0f;

        transform.Translate(y, x, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Obstacle"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("this collided");
            scoreCount = scoreCount + 1;
            scoreText();
        }

       // else if (other.gameObject.CompareTag("Obstacle"))
     //   {
      //      Debug.Log("this collided with rock");
       // }
    }

    public void scoreText()
    {
        displayScore.text = "Score: " + scoreCount.ToString();
    }
}
