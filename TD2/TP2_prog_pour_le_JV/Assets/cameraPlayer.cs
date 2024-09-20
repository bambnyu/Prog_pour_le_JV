using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer : MonoBehaviour
{
    public GameObject car;
    public float distanceThreshold = 50.0f;
    public bool following = false;
    public Vector3 decalage;

    void Start()
    {
        transform.position = new Vector3(20, 6, -4);
        decalage = new Vector3(15, 6, -2);
        
    }

    void Update()
    {
        

        float distance = Vector3.Distance(car.transform.position, transform.position);
        Debug.Log(following);
        Debug.Log(distance);
        if (distance > distanceThreshold)
        {
            following = true;
        }

        if (following){
                transform.position = car.transform.position + decalage;
                transform.LookAt(car.transform);
        }
        if (!following) {
            transform.LookAt(car.transform);
        }
    }
}
