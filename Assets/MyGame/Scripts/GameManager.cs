using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    string defaultText;
    int score = 0;
    //If Awake is called, it sets the instance
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    //if Game Over, it calles the StopScrolling Function and opens the GameOver Panel/Screen
    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }
    //Function to stop the (Background) Textures to Scroll, called above (Line 25)
    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach(TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
        }
    }
    //If Restart is called, it loads the Main Scene
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
    //If Menu is called, it loads the Menu Scene
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    //If IncrementScore is called, adds 1 to the score and converts it into a String
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
