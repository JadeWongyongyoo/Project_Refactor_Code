using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementScript : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene(0);
    }

    public void StoryScene()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayScene()
    {
        SceneManager.LoadScene(2);
    }

    public void GalleryScene()
    {
        SceneManager.LoadScene(3);
    }

    public void CreditScene()
    {
        SceneManager.LoadScene(4);
    }

    public void TutorialScene()
    {
        SceneManager.LoadScene(5);
    }

    public void MinigameScene()
    {
        SceneManager.LoadScene(6);
    }

    public void MinigameScene1()
    {
        SceneManager.LoadScene(7);
    }

    public void MinigameScene2()
    {
        SceneManager.LoadScene(8);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
