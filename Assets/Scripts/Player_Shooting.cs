using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float speed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
     
    }

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}