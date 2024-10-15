using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetitionArrierePlan : MonoBehaviour
{
    private Vector3 positionInitiale;

    public float limiteGauche = -11f;
    // Start is called before the first frame update
    void Start()
    {
        positionInitiale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < limiteGauche)
        {
            ReinitialiserPosition();
        }
    }
    void ReinitialiserPosition()
    {
        transform.position = positionInitiale;
    }
}