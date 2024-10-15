using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleTrigger : MonoBehaviour
{
    public float scaleMultiplier = 1.5f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "joueur")
        {
            Debug.Log("Player entered capsule trigger");

            
            other.transform.localScale *= scaleMultiplier;

            GestionCollision playerController = other.GetComponent<GestionCollision>();
            if (playerController != null)
            {
                playerController.ConsumeCapsule();
            }

            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Object entered trigger: " + other.gameObject.name);
        }
    }
}
