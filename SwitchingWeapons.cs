using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int selectedWeapon = 0; // The index of the currently selected weapon

    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {
        int previousWeapon = selectedWeapon;

        // Use the mouse scroll wheel to switch weapons
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = transform.childCount - 1;
            else
                selectedWeapon--;
        }

        // Use the number keys to switch weapons
        for (int i = 0; i < transform.childCount; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                selectedWeapon = i;
        }

        // If the selected weapon has changed, call the SelectWeapon function
        if (previousWeapon != selectedWeapon)
            SelectWeapon();
    }

    void SelectWeapon()
    {
        int weaponIndex = 0;

        // Loop through all child objects and activate only the selected weapon
        foreach (Transform weapon in transform)
        {
            if (weaponIndex == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);

            weaponIndex++;
        }
    }
}
