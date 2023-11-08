using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayNG()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ContinueGame()
    {
        int lvl = PlayerPrefs.GetInt("lvl");
        if (lvl > 1)
        {
            SceneManager.LoadScene(lvl);
        }
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
