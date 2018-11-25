using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeItGlow : MonoBehaviour {

    public Image sprite;
    public Color spriteColor;
    public Color originalColor;

    private void Start()
    {
        originalColor = sprite.color;
    }
    private void Update()
    {
        if(Firebreathing.canBreathe)
        {
            glow();
        }
        if(Firebreathing.hasBreathed)
        {
            defaultColor();
        }
    }

    void glow()
    {
        sprite = sprite.GetComponent<Image>();
        sprite.color = Color.white;
    }

    void defaultColor()
    {
        sprite = sprite.GetComponent<Image>();
        sprite.color = originalColor;
    }
}
