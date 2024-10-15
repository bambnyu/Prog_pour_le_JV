using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementAnimal : MonoBehaviour
{
    public float vitesse = 5f; // Vitesse � laquelle l'animal descend
    public float limiteBas = -10f; // Limite en bas de la sc�ne o� l'animal sera d�truit

    void Update()
    {
        // D�placer l'animal vers le bas (direction de l'axe Y n�gatif)
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);

        // V�rifier si l'animal est sorti en bas de la sc�ne
        if (transform.position.z < limiteBas)
        {
            // D�truire l'animal une fois qu'il d�passe la limite
            Destroy(gameObject);
        }
    }
}
