using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public GameObject other;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            if (gameObject.tag == "Apple")
            {
                gameObject.SetActive(false);
                Debug.Log("the apple thing worked");
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
