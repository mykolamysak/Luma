using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text CoinsTxt;
    int CoinsCount;

    public static GameManager Instance;

    public Spawner spawner;
    public PlayerController playerController;
    public TMP_Text Scoretxt;

    public RectTransform GameOverScreen;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateScore()
    {
        CoinsCount++;
        CoinsTxt.text = "Coins: " + CoinsCount;
    }

    public void StartGame()
    {
        spawner.enabled = true;
        playerController.enabled = true;
        GameOverScreen.gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        GameOverScreen.gameObject.SetActive(true);
        spawner.enabled = false;
        playerController.enabled = false;

        Scoretxt.text = "YOUR SCORE: " + CoinsCount;

    }
}
