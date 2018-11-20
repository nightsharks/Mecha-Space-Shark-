using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Transform objectA;
    public Transform objectB;
    public Text UIText;

    public static string otherUIText = "test";
    public float distanceNumber;
    public static int distanceInt = 10;

    private void Start()
    {
        UIText.text = "";
        distanceNumber = 0;
    }
    public void LateUpdate()
    {
        distanceNumber = Vector3.Distance(objectA.position, objectB.position) / 15;
        distanceInt = Mathf.RoundToInt(distanceNumber);

        UIText.text = "Distance Traveled: " + distanceInt;

        otherUIText = "Final Distance: " + distanceInt;
    }
}
