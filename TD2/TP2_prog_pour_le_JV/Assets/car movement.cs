using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    public float consommation = 0.01f;
    private GestionVoiture gestionVoiture;

    void Start()
    {
        gestionVoiture = new GestionVoiture();
    }

    void Update()
    {
        if (gestionVoiture.roule(consommation))
        {
            //// Déplacement de la voiture vers l'avant et l'arrière
            if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            else
            {
                gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    gameObject.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    gameObject.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
                }
            }
            
        }
        else
        {
            Debug.Log("Not enough fuel to move");
        }
    }
}
