using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Transform[] WavePoints;
    public float Speed = 2f;
    int WaveIndex;
    private void Start()
    {
        transform.position = WavePoints[WaveIndex].transform.position;
    }

    private void Update()
    {
        if (WaveIndex <= WavePoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, 
                WavePoints[WaveIndex].transform.position, Speed * Time.deltaTime);
        }
        if (transform.position == WavePoints[WaveIndex].transform.position)
        {
            WaveIndex++;
        }
    }
}
