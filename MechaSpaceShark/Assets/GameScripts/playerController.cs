using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int scoreCount;
    public Text displayScore;
    public static int finalScore = 0;
    public static float playerLocationX;
    public GameObject player;
    public float invincibleTime = 3.0f;
    public bool isInvincible = false;

    void OnEnable()
    {
        scoreCount = 0;
        scoreText();      
    }

     void Start()
    {
        
    }

    void Update()
    {
        playerLocationX = player.transform.localPosition.x;

        var y = Input.GetAxis("Vertical") * Time.deltaTime * 200.0f;
        var x = Time.deltaTime * 300.0f;

        transform.Translate(x, y, 0);

        if(Consumable.CollideWithFood)
        {
            scoreCount++;
            scoreText();
        }

        if (ShieldPickup.PickedUpShield)
        {
            invincibility();
           // Debug.Log("invis");
        }

        if (Obstacle.CollideWithAsteroid)
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

    public void invincibility()
    {
        isInvincible = true;

        CancelInvoke("SetDamageable"); 
        Invoke("SetDamageable", invincibleTime);
    }

    void SetDamageable()
    {
        if(Obstacle.CollideWithAsteroid)
        {
            Obstacle.CollideWithAsteroid = false;
            Debug.Log("collision false");
        }
    }
}
