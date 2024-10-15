using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacerObjet : MonoBehaviour
{
    public float vitesse = 5f;

    private ControlePersonnage controlePersonnage;

    // Start is called before the first frame update
    void Start()
    {
        controlePersonnage = GameObject.Find("Player").GetComponent<ControlePersonnage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controlePersonnage.jeuTermine)
        {
            return; // Ne pas continuer à déplacer l'arrière-plan
        }

        transform.Translate(Vector3.left * vitesse * Time.deltaTime);
    }
}