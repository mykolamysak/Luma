using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public float Speed = 1f;
    Material Mat;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        Mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * Speed) / 10;
        Mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
