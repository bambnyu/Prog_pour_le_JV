using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireObject : MonoBehaviour
{
    // Limites de la scène
    public float limiteHaut = 20f;    // Limite en haut de la scène
    public float limiteBas = -10f;    // Limite en bas de la scène
    public float limiteGauche = -20f; // Limite à gauche
    public float limiteDroite = 20f;  // Limite à droite

    void Update()
    {
        // Vérifier si le projectile est en dehors des limites
        if (transform.position.z > limiteHaut || transform.position.z < limiteBas ||
            transform.position.x < limiteGauche || transform.position.x > limiteDroite)
        {
            // Détruire l'objet une fois hors des limites
            Destroy(gameObject);
        }
    }
}
