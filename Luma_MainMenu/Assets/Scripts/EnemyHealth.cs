using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 1;
    public bool IsAstroid = true;
    public GameObject Effect;
    public GameObject coin;

    public Slider HealthSlider;

    private void Start()
    {
        if (IsAstroid)
        {
            Health = 1;
        }
        else
        {
            Health = Random.Range(3, 4);
            HealthSlider.maxValue = Health;
            HealthSlider.value = Health;
        }
    }

    public void Damage(int health)
    {
        Health -= health;
        if (!IsAstroid)
        {
            HealthSlider.value = Health;
        }
        

        if (Health <= 0) 
        {
            Destroy(this.gameObject);
            CreateEffect();
            CreateCoin();
        }
    }

    public void CreateEffect()
    {
            GameObject effect = Instantiate(Effect,transform.position, Quaternion.identity);
            Destroy(effect, .55f);
    }
    public void CreateCoin()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
