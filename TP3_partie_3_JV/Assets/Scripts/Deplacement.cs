using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float vitesse = 10f; // Vitesse du projectile

    void Update()
    {
        // Déplacer l'objet vers l'avant (en direction de l'axe Z) à la vitesse spécifiée
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);
    }
}
