using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f; // Nouvelle variable pour la vitesse de rotation
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
            // D�placement de la voiture vers l'avant et l'arri�re
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
            }

            // Rotation de la voiture
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
        else
        {
            Debug.Log("Not enough fuel to move");
        }
    }
}
