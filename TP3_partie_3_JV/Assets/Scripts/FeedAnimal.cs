using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedAnimal : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Animal")
        {
            Debug.Log("Animal has been fed!");
            Destroy(collision.gameObject);
        }
    }
}
