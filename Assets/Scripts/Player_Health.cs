using UnityEngine;

public class Player_Health : MonoBehaviour, IDamageable
{
    public float maxHealth = 10;

    [SerializeField]
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Die()
    {
        Debug.Log("Player Death");
        //Die
    }

    float IDamageable.TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        return currentHealth;
    }
}