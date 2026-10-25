using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public string currentWeapon = "";

    void Start()
    {
        // Geen wapen gekozen: laat de Default-stats zien
        ShowWeaponStats();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = "Sword";
            ShowWeaponStats();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = "Bow";
            ShowWeaponStats();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = "Staff";
            ShowWeaponStats();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentWeapon = "Dagger";
            ShowWeaponStats();
        }
    }

    void ShowWeaponStats()
    {
        int damage;
        float speed;

        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                speed = 1.0f;
                break;
            case "Bow":
                damage = 20;
                speed = 1.5f;
                break;
            case "Staff":
                damage = 35;
                speed = 0.7f;
                break;
            case "Dagger":
                damage = 15;
                speed = 2.0f;
                break;
            default:
                damage = 10;
                speed = 1.0f;
                break;
        }

        string weaponName = string.IsNullOrEmpty(currentWeapon) ? "Default" : currentWeapon;
        Debug.Log("Weapon: " + weaponName + " | Damage: " + damage + " | Speed: " + speed);
    }
}