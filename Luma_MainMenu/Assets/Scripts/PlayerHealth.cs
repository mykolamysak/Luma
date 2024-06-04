using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 20;
    public Slider PlayerHealthSlider;
    public GameObject Effect;
    public GameManager gameManager;



    // Start is called before the first frame update
    void Start()
    {
        PlayerHealthSlider.maxValue = Health;
        PlayerHealthSlider.value = Health;
        gameManager.StartGame();
    }

    public void TakeDamage(int health)
    {
        Health -= health;
        PlayerHealthSlider.value = Health;
        if (Health <= 0)
        {
            this.gameObject.SetActive(false);
            CreateEffect();
            gameManager.GameOver();
            //this.GetComponent<SpriteRenderer>().enabled = false;
            //this.GetComponent<PlayerController>().enabled = false;


            //Destroy(this.gameObject);
        }
    }
    public void CreateEffect()
    {
        GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(effect, .55f);
    }
}
