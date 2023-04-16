using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DK_SceneLoad : MonoBehaviour
{
    public void SceneChange1()
    {
        SceneManager.LoadScene(5);
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene(8);
    }



    public void SceneMenu()
    {
        SceneManager.LoadScene(4);
    }

    //public void levelOneRetry()
    //{
    //    SceneManager.LoadScene(5);
    //}

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void button_exit()
    {
        Application.Quit();
    }

    //public void GameOver1()
    //{
    //    gameManag.SetCurrentLevel(2);
    //    gameManag.GameOverMenu();
    //}

    //public void GameOver2()
    //{
    //    gameManag.SetCurrentLevel(1);
    //    gameManag.GameOverMenu();
    //}
}
