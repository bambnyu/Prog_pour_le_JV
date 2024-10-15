using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float limiteGauche = -1f; // Limite � gauche
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= limiteGauche)
        {
            // D�truire l'objet une fois hors des limites
            Destroy(gameObject);
        }
    }
}
