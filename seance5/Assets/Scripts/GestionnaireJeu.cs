using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    private CoffreVoiture coffrevoiture;
    private CoffreVoiture coffreVoiture2;

    // Start is called before the first frame update
    void Start()
    {
        coffrevoiture = new CoffreVoiture();
        coffreVoiture2 = new CoffreVoiture(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D)) {
            // detruire l'objet coffre
            //coffrevoiture = null;
            Destroy(coffrevoiture);

        }
    }
}

public class CoffreVoiture : MonoBehaviour
{
    private float X;
    //définition du constructeur par défaut
    public CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture a été crée");
    }

    public CoffreVoiture(float x)
    {
        X = x;
        Debug.Log("Coffre de la voiture a été créé avec l’argument suivant: "+ x);
    }
    ~CoffreVoiture()
    { 
        Debug.Log("Le coffre de la voiture sera maintenant détruit! ");

    }

}
