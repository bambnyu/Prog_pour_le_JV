using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float vitesse = 10f; // Vitesse du projectile

    void Update()
    {
        // D�placer l'objet vers l'avant (en direction de l'axe Z) � la vitesse sp�cifi�e
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);
    }
}
