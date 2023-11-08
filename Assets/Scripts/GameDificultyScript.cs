using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDificultyScript : MonoBehaviour
{
    private int lvl;
    public void Hardcore()
    {
        PlayerPrefs.SetInt("dif", 0);
        lvl = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("lvl", lvl);
        SceneManager.LoadScene(lvl);
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("dif", 1);
        lvl = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("lvl", lvl);
        SceneManager.LoadScene(lvl);
    }

    public void Easy()
    {
        PlayerPrefs.SetInt("dif", 3);
        lvl = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("lvl", lvl);
        SceneManager.LoadScene(lvl);
    }
}
