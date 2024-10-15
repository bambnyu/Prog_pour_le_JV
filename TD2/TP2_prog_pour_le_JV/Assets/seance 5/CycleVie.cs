using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CycleVie;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class CycleVie : MonoBehaviour
{
    private CoffreVoiture coffrevoiture;

    public void Awake()
    {
        Debug.Log("La voiture se r�veille");
    }
    public void Start()
    {
        Debug.Log("La voiture finit son param�trage juste avant son utilisation");
        coffrevoiture = new CoffreVoiture(4);
    }

    private void OnDestroy()
    {
        Debug.Log(" La voiture est en voie de destruction");
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            coffrevoiture = null;
        }

    }

}


public class CoffreVoiture 
{
    private float X;
    //d�finition du constructeur par d�faut
    public CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture a �t� cr�e");
    }

    public CoffreVoiture(float x)
    {
        X = x;
        Debug.Log("Coffre de la voiture a �t� cr�� avec l�argument suivant: " + x);
    }
    ~CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture sera maintenant d�truit! ");

    }

}
