using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private float vitesse = 10f;
    private Rigidbody rb;

    private bool canDestroyObstacles = false;

    private Vector3 movementInput;
    private float rotationInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical"); 
        float moveHorizontal = Input.GetAxis("Horizontal");

        movementInput = transform.forward * moveVertical * vitesse;
        rotationInput = moveHorizontal;
    }

    private void FixedUpdate()
    {
        if (movementInput != Vector3.zero)
        {
            rb.MovePosition(rb.position + movementInput * Time.fixedDeltaTime);
        }

        if (rotationInput != 0)
        {
            Quaternion rotation = Quaternion.Euler(0, rotationInput * 90f * Time.fixedDeltaTime, 0);
            rb.MoveRotation(rb.rotation * rotation);
        }
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    public void ConsumeCapsule()
    {
        canDestroyObstacles = true;
        Debug.Log("Player can now destroy obstacles!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle" && canDestroyObstacles)
        {
            Destroy(collision.gameObject);
            Debug.Log("Obstacle destroyed!");

            CheckRemainingObstacles();
        }
    }

    private void CheckRemainingObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        if (obstacles.Length == 0)
        {
            Debug.Log("All obstacles destroyed! Game Over!");
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over!");
    }
}
