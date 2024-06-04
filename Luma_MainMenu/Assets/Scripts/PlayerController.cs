using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public float MaxY = (float)3.4;
    public float MinY = (float)-3.4;
    public GameObject Bullet;
    public Transform BulletPoint;
    public float Period = (float)0.3;
    float timerFire;
    void Start()
    {
        timerFire = Period;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Pos = transform.position;

        Pos += new Vector2(0, Speed) * Time.deltaTime * Input.GetAxis("Vertical");
        Pos.y = Mathf.Clamp(Pos.y, MinY, MaxY);

        transform.position = Pos;

        if (Input.GetMouseButton(0) && timerFire >= Period) //GetMouseButtonDown
        {
            SpawnBullet();
            timerFire = 0;
        }
        timerFire = timerFire + Time.deltaTime;
    }

    public void SpawnBullet()
    {
        Instantiate(Bullet, BulletPoint.position, Bullet.transform.rotation);
    }
}
