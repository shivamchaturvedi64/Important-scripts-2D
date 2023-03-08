using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 5f;  // Speed of movement
    public float jumpForce = 10f;  // Force of jump
    public Rigidbody2D rb;  // Reference to Rigidbody2D component

    private bool isGrounded = false;  // Whether or not player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Get reference to Rigidbody2D component
    }

    void Update()
    {
        // Move left and right
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if player is on the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
