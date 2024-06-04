using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed = 5f;
    public GameObject Bullet;
    public Transform BulletPoint;
    public Transform BulletPoint2;


    public Rigidbody2D Rb;
    public float MaxTime = 1f;
    float CurrentTime = 0f;

    public bool IsDouble = false;




    private void Start()
    {
        if(IsDouble)
        {
            Rb.AddForce(new Vector2(Speed, Rb.velocity.y), ForceMode2D.Impulse);
        }        
    }

    private void Update()
    {
        CurrentTime += Time.deltaTime;
        if(CurrentTime >= MaxTime)
        {
            SpawnBullet1();
            SpawnBullet2();
            CurrentTime = 0;
        }
    }

    private void SpawnBullet1()
    {
        if(IsDouble) 
        {
            Instantiate(Bullet, BulletPoint.position, Bullet.transform.rotation);
        }        
    }
    private void SpawnBullet2()
    {
        Instantiate(Bullet, BulletPoint2.position, Bullet.transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            this.GetComponent<EnemyHealth>().CreateEffect();
            Destroy(this.gameObject);
        }
    }
}
