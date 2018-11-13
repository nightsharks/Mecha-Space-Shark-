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
    public static float distanceNumber = 0;

    private void Start()
    {
        UIText.text = "";
    }
    public void LateUpdate()
    {
        distanceNumber = Vector3.Distance(objectA.position, objectB.position);

        UIText.text = "Distance Traveled: " + distanceNumber.ToString("F0");

        otherUIText = "Final Distance: " + distanceNumber.ToString("F0");
    }
}
