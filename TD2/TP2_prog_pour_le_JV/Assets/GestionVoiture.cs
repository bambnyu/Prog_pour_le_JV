using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionVoiture : MonoBehaviour
{
    private double essence;
    public GestionVoiture()
    { 
        essence = 10;
        Debug.Log("Essence :" + essence);
        
    }
    public double getEssence()
    {
        return essence;
    }
    public void setEssence(double valeur)
    {
        essence = valeur;
    }
    public bool roule(double consommation)
    {
        essence -= consommation;
        if (essence <= 0)
        {
            return false;
        }
        return true;


    }

}
