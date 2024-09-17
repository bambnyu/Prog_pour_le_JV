using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer : MonoBehaviour
{
    public GameObject car;
    public Vector3 decalage;
    // Start is called before the first frame update
    void Start()
    {
        decalage = new Vector3(-3, 6, -7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + decalage;
    }
}
