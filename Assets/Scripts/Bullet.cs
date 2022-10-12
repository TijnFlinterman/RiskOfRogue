using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<IDamageable>() != null)
        {
            collision.GetComponentInParent<IDamageable>().TakeDamage(damage);
        }
    }
}