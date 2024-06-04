using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D Rb;

    public bool IsPlayer = true;

    // Start is called before the first frame update
    void Start()
    {
        Rb.AddForce(new Vector2(Speed, Rb.velocity.y), ForceMode2D.Impulse);
        Destroy(this.gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != null)
        {
            if (IsPlayer)
            {
                if (collision.gameObject.CompareTag("Enemy"))
                {
                    collision.gameObject.GetComponent<EnemyHealth>().Damage(1);
                    Destroy(this.gameObject);
                }

                if (collision.gameObject.CompareTag("Coin"))
                {
                    if(GameManager.Instance != null)
                    {
                        GameManager.Instance.UpdateScore();
                    }
                    Destroy(collision.gameObject);
                }
            }
            else
            {
                if (collision.gameObject.CompareTag("Player"))
                {
                    collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
                    Destroy(this.gameObject);
                }
                
            }
            
            
        }
    }
}
