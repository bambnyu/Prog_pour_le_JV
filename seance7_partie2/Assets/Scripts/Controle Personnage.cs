using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonnage : MonoBehaviour
{
    private Rigidbody instanceRigidBody;
    public float forceDeSaut = 10f;

    public float facteurGravite = 3f; //q9

    private bool estAuSol = false;
    public bool jeuTermine = false;

    private Animator animator;
    public ParticleSystem explosionSmoke;
    public ParticleSystem effetPoussiere;

    public AudioClip sautSon;
    public AudioClip collisionSon;
    public AudioSource audioSource;  ///ici

    // Start is called before the first frame update
    void Start()
    {
        instanceRigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();  ///icci

        Physics.gravity *= facteurGravite;
    }

    // Update is called once per frame
    void Update()
    {
        if (jeuTermine)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && estAuSol)
        {
            // Appliquer une force vers le haut pour faire sauter le personnage
            instanceRigidBody.AddForce(Vector3.up * forceDeSaut, ForceMode.Impulse);
            estAuSol = false;

            animator.SetTrigger("Jump_trig");

            audioSource.PlayOneShot(sautSon);

            effetPoussiere.Stop();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // Vérifier si la collision est avec un objet tagué comme "Sol"
        if (collision.gameObject.CompareTag("Sol"))
        {
            estAuSol = true;
            effetPoussiere.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Fin du jeu");
            jeuTermine = true; // Le jeu est terminé


            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);

            explosionSmoke.Play();

            effetPoussiere.Stop();

            audioSource.PlayOneShot(collisionSon);

        }
    }
}