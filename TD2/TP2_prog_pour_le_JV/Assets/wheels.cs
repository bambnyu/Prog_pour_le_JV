using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movemement : MonoBehaviour
{
    public float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(- speed * Time.deltaTime, 0, 0); // roue qui recule
        }
        else
        {
            gameObject.transform.Rotate(speed * Time.deltaTime, 0, 0); // roue qui tourne

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Rotate(0,- speed * Time.deltaTime / 4, 0, Space.World); // tourne par rapport au monde
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Rotate(0,  speed * Time.deltaTime/ 4, 0, Space.World); // tourne par rapport au monde
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.Rotate(speed * Time.deltaTime*2, 0, 0); // roue acceleré
            }
        }
    }
}