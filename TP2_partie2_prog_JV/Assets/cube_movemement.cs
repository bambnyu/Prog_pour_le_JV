using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movemement : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 45 * Time.deltaTime, 0);

        Vector3 vecteur = new Vector3(0, 0, 1); // Move along the Z axis
        gameObject.transform.Translate(vecteur * speed * Time.deltaTime);
    }
}