using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public float maxHealth = 10;

    [SerializeField]
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        TakeDamage(1f);
    //    }
    //}

    public void TakeDamage(float Damage)
    {
        currentHealth -= Damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player Death");
        //Die
    }
}