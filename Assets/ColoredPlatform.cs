using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredPlatform : MonoBehaviour
{
    public GameObject platformActivation;
    [SerializeField] private bool p1;
    [SerializeField] private bool p2;
    private void OnTriggerEnter2D(Collider2D p)
    {
        if (p1 && !p2)
        {

            if (p.tag == "Player1")
            {
                platformActivation.SetActive(true);
            }
            else if (p.tag == "Player2")
            {
                platformActivation.SetActive(false);
            }
        }
        else if (!p1 && p2)
        {
            if (p.tag == "Player2")
            {
                platformActivation.SetActive(true);
            }
            else if (p.tag == "Player1")
            {
                platformActivation.SetActive(false);

            }
        }
        
    }
}
