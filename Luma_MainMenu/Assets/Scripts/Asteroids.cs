using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float Speed = -5f;
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.AddForce(new Vector2(Speed, Rb.velocity.y), ForceMode2D.Impulse);
        //Destroy(this.gameObject, 3.5f);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
    //        Destroy(this.gameObject);
    //        this.GetComponent<EnemyHealth>().CreateEffect();            
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            this.GetComponent<EnemyHealth>().CreateEffect();
            Destroy(this.gameObject);
        }
    }

}
