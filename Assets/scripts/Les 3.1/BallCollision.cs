using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer objectRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        objectRenderer.material.color = Random.ColorHSV();
    }
}
