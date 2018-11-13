using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int scoreCount;
    public Text displayScore;
    public static int finalScore = 0;   
    public static int finalDistance = 0;

    public static float playerLocationX;
    public GameObject player;

    public GameObject sprite;
    private IEnumerator coroutine;
    private float invincibleSeconds = 3.0f;

    SpriteRenderer invincibility;
    Color invincibilityColor;

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
            invincibilityGlow();
            coroutine = TimeIsDone(invincibleSeconds);
            StartCoroutine(coroutine);           
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

    IEnumerator TimeIsDone(float waitTime)
    {
        yield return new WaitForSeconds(3f);
        ShieldPickup.PickedUpShield = false;
        returnToDefaultColor();
    }

    public void invincibilityGlow()
    {
        if(ShieldPickup.PickedUpShield)
        {
            invincibility = sprite.GetComponent<SpriteRenderer>();
            invincibility.color = Color.yellow;
            Debug.Log("default");
        }
    }

    public void returnToDefaultColor()
    {
        invincibility = sprite.GetComponent<SpriteRenderer>();
        invincibility.color = Color.white;
        Debug.Log("blue");
    }
}
