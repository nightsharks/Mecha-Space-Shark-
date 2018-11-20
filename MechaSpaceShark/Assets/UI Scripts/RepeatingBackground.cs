﻿using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;    
    private float groundHorizontalLength;      

    [SerializeField]

    private Transform playerTransform;
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();

        groundHorizontalLength = groundCollider.size.x * transform.localScale.x;
        playerTransform = GameObject.FindWithTag("Player").transform;
    }


    private void Update()
    {
     
        if (transform.position.x + groundHorizontalLength / 2 < playerTransform.position.x)
        {

            RepositionBackground();
            Debug.Log("test");
        }
    }

    
    private void RepositionBackground()
    {
    
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

        
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}