using UnityEngine;

public class BadCarMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private GestionVoiture gestionVoiture;

    void Start()
    {
        gestionVoiture = new GestionVoiture();
    }

    void Update()
    {
        Vector3 vecteur = new Vector3(0, 0, -1); // Move along the Z axis
        gameObject.transform.position += vecteur * speed * Time.deltaTime;
    }
}
