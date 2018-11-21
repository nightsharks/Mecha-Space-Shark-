using UnityEngine;
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
        if (playerTransform.position.x > transform.position.x + groundHorizontalLength / 2 + 1000 ) // idk why 1000 works it just does
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