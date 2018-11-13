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
    public static int distanceInt;

    private void Start()
    {
        UIText.text = "";
    }
    public void LateUpdate()
    {
        distanceNumber = Vector3.Distance(objectA.position, objectB.position);
        int distanceInt = (int)Math.Round(distanceNumber);

        UIText.text = "Distance Traveled: " + distanceInt;

        otherUIText = "Final Distance: " + distanceInt;
    }
}
