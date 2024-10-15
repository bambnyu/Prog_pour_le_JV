using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementAnimal : MonoBehaviour
{
    public float vitesse = 5f; // Vitesse à laquelle l'animal descend
    public float limiteBas = -10f; // Limite en bas de la scène où l'animal sera détruit

    void Update()
    {
        // Déplacer l'animal vers le bas (direction de l'axe Y négatif)
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);

        // Vérifier si l'animal est sorti en bas de la scène
        if (transform.position.z < limiteBas)
        {
            // Détruire l'animal une fois qu'il dépasse la limite
            Destroy(gameObject);
        }
    }
}
