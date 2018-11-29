using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireProgress : MonoBehaviour {

    public Image progress;
    private float onCollect;
    private float startsAt;

    public static bool enoughFuel;
    private void Start()
    {
        onCollect = .125f; // 100% / 8 sections
        startsAt = 0f;
        enoughFuel = false;
    }

    private void Update()
    {
        if (Consumable.CollideWithFood)
        {            
            startsAt += onCollect;
            progress.fillAmount = startsAt;
            Debug.Log("filled");
        }

        if(progress.fillAmount > .95)
        {
            Firebreathing.canBreathe = true;
            enoughFuel = true;
        }     
        if(Firebreathing.hasBreathed)
        {
            progress.fillAmount = 0;
            startsAt = 0f;
            enoughFuel = false;
        }
    }
}
