using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb.AddForce(new Vector2(Speed, Rb.velocity.y), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
