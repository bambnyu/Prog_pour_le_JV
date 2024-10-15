using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    public GameObject modeleObstacle;
    public Vector3 positionCreation = new Vector3(10f, 0f, 0f);
    public float intervalleCreation = 2f; // a bouger et en faire un random

    private ControlePersonnage controlePersonnage;

    // Start is called before the first frame update
    void Start()
    {
        controlePersonnage = GameObject.Find("Player").GetComponent<ControlePersonnage>();
        InvokeRepeating("CreerObstacle", 0f, intervalleCreation);
    }

    // Update is called once per frame
    void Update()
    {
        if (controlePersonnage.jeuTermine)
        {
            CancelInvoke("CreerObstacle");
        }
    }

    void CreerObstacle()
    {
        if (!controlePersonnage.jeuTermine)
        {
            // Instancier le modèle d'obstacle à la position définie
            Instantiate(modeleObstacle, positionCreation, Quaternion.identity);
        }
    }
}

