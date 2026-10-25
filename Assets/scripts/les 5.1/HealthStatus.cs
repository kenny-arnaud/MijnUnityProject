using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public int healthChange = 10;

    void Start()
    {
        ShowHealthStatus();
    }

    void Update()
    {
        // H = health omlaag
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= healthChange;
            ShowHealthStatus();
        }

        // J = health omhoog
        if (Input.GetKeyDown(KeyCode.J))
        {
            health += healthChange;
            ShowHealthStatus();
        }
    }

    void ShowHealthStatus()
    {
        if (health > 80)
        {
            Debug.Log("Health: " + health + " - Excellent health");
        }
        else if (health > 50)
        {
            Debug.Log("Health: " + health + " - Good health");
        }
        else if (health > 20)
        {
            Debug.Log("Health: " + health + " - Warning: Low health");
        }
        else
        {
            Debug.Log("Health: " + health + " - Critical: Very low health");
        }
    }
}