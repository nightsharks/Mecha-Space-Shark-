using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public static bool CollideWithRock = false;
    public static bool CollideWithFood = false;

    public List<GameObject> inactive = new List<GameObject>();

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("apple");
            CollideWithFood = true;
            inactive.Add(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("rock");
            CollideWithRock = true;
        }
        
    }


    void LateUpdate()
    {
        CollideWithFood = false;
    }
}
