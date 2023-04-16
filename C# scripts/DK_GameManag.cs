using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DK_GameManag : MonoBehaviour
{
    public int score = 0;
    public int lives = 6;
    private int currentLives;

    public static DK_GameManag Instance;
    public TextMeshProUGUI scoreText;
    public Image[] healthIcons;
    public TextMeshProUGUI needPointsText;

    //private int currentLevel = 1;

    private void Start()
    {
        currentLives = lives;
        UpdateHealthBar();

        UpdateScoreText();
    }

    void Update()
    {
        if(lives <= 0)
        {
            SaveScore();
            SceneManager.LoadScene(7);
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //public void SceneChange()
    //{
    //    SceneManager.LoadScene("DK_Lvl" + currentLevel);
    //}

    //public void SetCurrentLevel(int level)
    //{
    //    currentLevel = level;
    //}

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public int GetLives()
    {
        return lives;
    }

    public void UpdateHealthBar()
    {
        for(int i = 0; i < healthIcons.Length; i++)
        {
            healthIcons[i].gameObject.SetActive(i < currentLives);
        }
    }
    public void Loselife(int damage)
    {
        currentLives -= damage;
        UpdateHealthBar();

        if(currentLives <= 0)
        {
            if(SceneManager.GetActiveScene().name == "DK_Lvl1")
            {
                SceneManager.LoadScene(7);
            }

            else if (SceneManager.GetActiveScene().name == "DK_Lvl2")
            {
                SceneManager.LoadScene(9);
            }
        }

    }

    public void CompleteLevel()
    {
        SaveScore();

        if(score >= 250)
        {
            SceneManager.LoadScene(10);
        }
        else
        {
            needPointsText.text = "You need 250 or more points to proceed!!";
            Color color = needPointsText.color;
            color.a = 1;
            needPointsText.color = color;
            Debug.Log("Player need at least 250 points to proceed");
        }
    }

    public void CompleteLevel2()
    {
        SaveScore();

        if (score >= 450)
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            needPointsText.text = "You need 450 or more points to proceed!!";
            Color color = needPointsText.color;
            color.a = 1;
            needPointsText.color = color;
            Debug.Log("Player need at least 450 points to proceed");
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
    }

    public void WinGame()
    {
        Debug.Log("Congratulations, you win!");
        CompleteLevel();
    }

    public void WinGame2()
    {
        Debug.Log("Congratulations, you win!");
        CompleteLevel2();
    }

    public void LoseGamefall()
    {
        Debug.Log("You lose! Don't fall!");
        SaveScore();
        SceneManager.LoadScene(7);
    }

    public void LoseGamefall2()
    {
        Debug.Log("You lose! Don't fall!");
        SaveScore();
        SceneManager.LoadScene(9);
    }

}
