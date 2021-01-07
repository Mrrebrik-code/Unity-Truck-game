using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public int maxLevl;
    public int levl;
    [SerializeField] private int levlContinue;

    public void LoadGame()
    {
        SceneManager.LoadScene(levl);
    }

    public void Continue()
    {
        SceneManager.LoadScene(levlContinue);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void RandomGame()
    {
        int i = Random.Range(1, maxLevl);
        SceneManager.LoadScene(i);
    }
}
