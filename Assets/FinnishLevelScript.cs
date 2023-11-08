using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinnishLevelScript : MonoBehaviour
{
    [SerializeField] private bool p1In = false;
    [SerializeField] private bool p2In = false;
    [SerializeField] private int lvl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            p1In = true;
        }

        if (collision.tag == "Player2")
        {
            p2In = true;
        }
    }

    private void Update()
    {
        if (p1In && p2In)
        {
            lvl = SceneManager.GetActiveScene().buildIndex + 1;
            PlayerPrefs.SetInt("lvl", lvl);
            SceneManager.LoadScene(lvl);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            p1In = false;
        }

        if (collision.tag == "Player2")
        {
            p2In = false;
        }
    }
}
