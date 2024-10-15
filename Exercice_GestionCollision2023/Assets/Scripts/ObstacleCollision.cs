using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private Renderer obstacleRenderer;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRenderer = GetComponent<Renderer>();
        if (obstacleRenderer != null)
        {
            
            originalColor = obstacleRenderer.material.color;
            Debug.Log("Original color stoyellow: " + originalColor);
        }
        else
        {
            Debug.LogError("Renderer not found on this obstacle!");
        }
    }

        // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "joueur")
        {
            Debug.Log("Collision started with joueur");
            obstacleRenderer.material.color = Color.yellow;
        }
        else
        {
            Debug.Log("Collision started with object not tagged as joueur: " + collision.gameObject.name);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "joueur")
        {
            Debug.Log("Collision ongoing with joueur");
            obstacleRenderer.material.color = Color.yellow;
        }
    } 

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "joueur")
        {
            Debug.Log("Collision ended with joueur");
            obstacleRenderer.material.color = originalColor;
        }
    }
}
