using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlejoueur : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse du personnage
    public float limiteGauche = -10f; // Limite gauche du terrain
    public float limiteDroite = 10f;  // Limite droite du terrain

    public GameObject projectile;

    void Update()
    {
        float mouvementHorizontal = Input.GetAxis("Horizontal");

        // Calculer la nouvelle position basée sur l'entrée utilisateur
        Vector3 nouvellePosition = transform.position + new Vector3(mouvementHorizontal * vitesseDeplacement * Time.deltaTime, 0, 0);

        // Vérifier que la nouvelle position est dans les limites
        if (nouvellePosition.x < limiteGauche)
        {
            nouvellePosition.x = limiteGauche;
        }
        else if (nouvellePosition.x > limiteDroite)
        {
            nouvellePosition.x = limiteDroite;
        }

        // Appliquer la position corrigée au personnage
        transform.position = nouvellePosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instancier un projectile à la position actuelle du joueur avec la rotation du projectile
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
