using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour
{
    [SerializeField]private int lvl;
    void Awake()
    {
        lvl = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("lvl", lvl);
        SceneManager.LoadScene(lvl);
    }

}
