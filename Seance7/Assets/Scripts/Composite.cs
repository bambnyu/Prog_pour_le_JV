using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Récupérer tous les sous-objets de l'objet composite
        Transform[] childObjects = GetComponentsInChildren<Transform>();

        // Afficher les noms des sous-objets dans la console
        foreach (Transform child in childObjects)
        {
            Debug.Log("Sous-objet: " + child.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Transform jambe1 = transform.Find("jambe1");
            Transform jambe2 = transform.Find("jambe2");
            Transform jambe3 = transform.Find("jambe3");
            Transform jambe4 = transform.Find("jambe4");

            jambe1.localScale *= 0.75f; // Réduit la taille de 25%
            jambe2.localScale *= 0.75f;
            jambe3.localScale *= 0.75f;
            jambe4.localScale *= 0.75f;
        }
    }

}