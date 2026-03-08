using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public int defaultHealthPoint = 3;
    public GameObject explosionPrefab;

    public Action onDead;   // ✅ ĐẶT TRONG CLASS

    protected int currentHealth;

    protected virtual void Start()
    {
        currentHealth = defaultHealthPoint;
    }

    public virtual void TakeDamage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(
                explosionPrefab,
                transform.position,
                transform.rotation
            );

            Destroy(explosion, 1f);
        }

        Destroy(gameObject);

        onDead?.Invoke();   // ✅ GỌI EVENT
    }
}