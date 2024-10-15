using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireObject : MonoBehaviour
{
    // Limites de la sc�ne
    public float limiteHaut = 20f;    // Limite en haut de la sc�ne
    public float limiteBas = -10f;    // Limite en bas de la sc�ne
    public float limiteGauche = -20f; // Limite � gauche
    public float limiteDroite = 20f;  // Limite � droite

    void Update()
    {
        // V�rifier si le projectile est en dehors des limites
        if (transform.position.z > limiteHaut || transform.position.z < limiteBas ||
            transform.position.x < limiteGauche || transform.position.x > limiteDroite)
        {
            // D�truire l'objet une fois hors des limites
            Destroy(gameObject);
        }
    }
}
