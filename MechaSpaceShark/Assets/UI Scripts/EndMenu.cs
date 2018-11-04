using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public GameObject EndMenuUI;
    public Text FinalScore;
    public Text DistanceTravelled;

    public void Start()
    {
        EndMenuUI.SetActive(false);
    }

    void Update()
    {
        
        if(Trigger.CollideWithRock)
        {
            EndMenuUI.SetActive(true);
            Time.timeScale = 0f;
            FinalScore.text = "Final Score: " + playerController.finalScore.ToString() ;
            DistanceTravelled.text = Distance.otherUIText;
        }

    }
}
