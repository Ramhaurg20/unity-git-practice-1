using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;

   void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }

    //public void TakeDamage(float ratio)
    //{
    //    health -= (int)(health * ratio);          //아직 배우지 않음.

    //}

    public float GetHealth()
    {
        return health;
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D coll)            //coll = collision.
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamege(10);
            coll.gameObject.SetActive(false);
        }
    }
   public virtual void move()
    {

    }

}

    

//    void Start()
//    {

//    }
//    void Update()
//    {
        
//    }
//}
