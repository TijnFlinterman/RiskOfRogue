using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    private Rigidbody2D rb;

    private float horizontal, vertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
    }
}