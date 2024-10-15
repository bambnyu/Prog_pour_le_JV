using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // values for the positions
    public float minX = -10f;
    public float maxX = 10f;
    public float fixedY = 0f;
    public float fixedZ = 0f;

    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnAnimalAutomatically", 2f, spawnInterval);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            float randomX = Random.Range(minX, maxX);
            Vector3 randomPosition = new Vector3(randomX, fixedY, fixedZ);
            Quaternion animalRotation = Quaternion.Euler(0f, 180f, 0f);
            CreationAnimal(randomPosition, animalRotation);
        }
    }

    public void CreationAnimal(Vector3 position, Quaternion rotation)
    {
        if (animalPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, animalPrefabs.Length);
            GameObject selectedPrefab = animalPrefabs[randomIndex];

            Instantiate(selectedPrefab, position, rotation);
        }
        
    }

    void SpawnAnimalAutomatically()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 randomPosition = new Vector3(randomX, fixedY, fixedZ);
        Quaternion animalRotation = Quaternion.Euler(0f, 180f, 0f);
        CreationAnimal(randomPosition, animalRotation);
    }

}
