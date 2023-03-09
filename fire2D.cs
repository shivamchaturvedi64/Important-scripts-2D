using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject bulletPrefab;  // Reference to bullet prefab
    public Transform firePoint;  // Reference to fire point
    public float bulletSpeed = 10f;  // Speed of bullet

    void Update()
    {
        // Check for input to fire
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate bullet prefab at fire point position and rotation
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            // Get reference to Rigidbody2D component of bullet
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            // Add force to the bullet to shoot it forward
            rb.AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
