using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public Rigidbody2D rb;
    Vector3 movespeed;
    Vector3 moveSpeedUpDown;

    private float horizontal, vertical;

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