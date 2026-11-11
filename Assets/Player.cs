using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100.0f;

    void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Player Health" + health);

    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamege(20);
        Destroy(collision.gameObject);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
