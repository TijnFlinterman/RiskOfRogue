using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float movementSpeedUpDown = 4f;
    Vector3 movespeed;
    Vector3 moveSpeedUpDown;

    void Start()
    {
        movespeed = new Vector3(movementSpeed, 0, 0);
        moveSpeedUpDown = new Vector3(0, movementSpeedUpDown, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + moveSpeedUpDown * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - moveSpeedUpDown * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + movespeed * Time.deltaTime;
        }
    }
}