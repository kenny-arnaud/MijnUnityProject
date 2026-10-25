using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 90f;
    public float bobSpeed = 2f;     
    public float bobHeight = 0.25f; 

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Draaien
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f, Space.World);

        // bewegen
        float newY = startPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}