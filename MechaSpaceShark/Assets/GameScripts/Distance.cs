using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{

    public Transform objectA;
    public Transform objectB;
    public Text UIText;
    public static string otherUIText = "";

    private void Start()
    {
        UIText.text = "";
    }
    public void LateUpdate()
    {
        UIText.text = "Distance Traveled: " + Vector3.Distance(objectA.position, objectB.position).ToString();

        otherUIText = UIText.ToString();
    }
}
