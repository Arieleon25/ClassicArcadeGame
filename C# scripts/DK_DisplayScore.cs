using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DK_DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText2;

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt("Score");
        scoreText2.text = "Final Score: " + finalScore.ToString();
    }
}
