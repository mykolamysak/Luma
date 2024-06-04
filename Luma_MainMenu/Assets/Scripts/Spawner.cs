using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject[] Astroids;
    public float Maxtime = 2f;
    float CurrentTime;

    public float MaxY, MinY;
    

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if(CurrentTime >= Maxtime)
        {
            CurrentTime = 0f;
            Maxtime = Random.Range(.6f, 2f);

            int Choose = Random.Range(0, 2);
            if (Choose == 1) 
            {
                SpawnEnemy();
            }else
            {
                SpawnAstroid();
            }
        }
    }
    public void SpawnEnemy()
    {
        Instantiate(Enemies[Random.Range(0,Enemies.Length)], 
            new Vector3(transform.position.x, 
            Random.Range(MinY,MaxY),0), Quaternion.identity);
    }
    public void SpawnAstroid()
    {
        Instantiate(Astroids[Random.Range(0, Astroids.Length)],
            new Vector3(transform.position.x,
            Random.Range(MinY, MaxY), 0), Quaternion.identity);
    }

}
