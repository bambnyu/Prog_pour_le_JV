using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public Color newColor = Color.green; 
    private Color originalColor; 

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer != null)
        {
            originalColor = meshRenderer.material.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (meshRenderer != null)
            {
          
                meshRenderer.material.color = newColor;
            }
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (meshRenderer != null)
            {
                meshRenderer.material.color = originalColor;
            }
        }
    }
}
