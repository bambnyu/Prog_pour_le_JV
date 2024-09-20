using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vecteur_test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Vector2  Pos = new Vector2 (5, 8);
        Vector2 vitesse = new Vector2 (3, 2);
        Vector3 Resultat2 = new Vector2(Pos.x+vitesse.x, Pos.y+vitesse.y);
        Debug.Log("Resultat : " + Resultat2);
        Pos.x = -1; Pos.y = -3;
        Vector2 Deplacement = new Vector2(-2, 2);
        Resultat2.x = Pos.x - Deplacement.x;
        Resultat2.y = Pos.y - Deplacement.y;
        Debug.Log("Resultat : " + Resultat2);


        Vector3 Position = new Vector3(-2, -1, 5);
        Vector3 Vitesse = new Vector3(1, 4, 3);
        Vector3 Resultat3 = new Vector3(Position.x + Vitesse.x, Position.y + Vitesse.y, Position.z + Vitesse.z);
        Debug.Log("Resultat : "+Resultat3);

        Position.x = 2; Position.y = -4; Position.z = 1;
        Vector3 Deplacement3 = new Vector3(-1, -1, 3);
        Resultat3.x = Position.x - Deplacement3.x;
        Resultat3.y = Position.y - Deplacement3.y;
        Resultat3.z = Position.z - Deplacement3.z;
        Debug.Log("Resultat : " + Resultat3);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
