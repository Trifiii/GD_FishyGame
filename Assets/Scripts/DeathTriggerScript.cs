using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LivesSystem
{

    public class DeathTriggerScript : MonoBehaviour
    {
        [SerializeField] private GameObject levelLostScreen;
        [SerializeField] private int lives;
        [SerializeField] private Text textBox;
        [SerializeField] private GameObject ply1;
        [SerializeField] private GameObject ply2;

        private string str;
        private Vector3 p1, p2;
        // Start is called before the first frame update
        void Start()
        {
            levelLostScreen.SetActive(false);
            lives = PlayerPrefs.GetInt("dif");
            str = string.Concat("lives:", lives);
            textBox.text = str;
            p1 = ply1.transform.position;
            p2 = ply2.transform.position;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
            {
                lives--;
                str = string.Concat("lives:", lives);
                textBox.text = str;
                ply1.transform.position = p1;
                ply2.transform.position = p2;

                if (lives < 0)
                {
                    levelLostScreen.SetActive(true);
                }
            }
        }
    }
}
