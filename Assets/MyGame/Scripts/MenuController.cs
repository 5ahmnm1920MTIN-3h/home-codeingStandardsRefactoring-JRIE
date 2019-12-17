using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public static string mainScene = "MainScene";
    //If Play is called, it loads the MainScene via the SceneManager
    public void Play(){
        SceneManager.LoadScene(mainScene);
    }
    //If Exit is called, it quits the Application if Built
    public void Exit()
    {
        Application.Quit();
    }
}
