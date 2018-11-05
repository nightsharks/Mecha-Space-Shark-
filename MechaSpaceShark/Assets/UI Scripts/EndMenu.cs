using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public GameObject EndMenuUI;
    public GameObject InGameUI;
    public Text FinalScore;
    public Text FinalDistance;

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
            FinalDistance.text = Distance.otherUIText.ToString();
            InGameUI.SetActive(false);
        }

    }
}
