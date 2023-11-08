using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsScript : MonoBehaviour
{
    public GameObject platformActivationP0;
    public GameObject platformActivationP1;
    public GameObject platformActivationP2;
    private bool ot = false;
    [SerializeField] private bool isAdaptive;
    void OnTriggerEnter2D(Collider2D target)
    {
        if (isAdaptive && !ot)
        {
            if (target.tag == "Player1")
            {
                platformActivationP0.SetActive(false);
                platformActivationP1.SetActive(true);
                platformActivationP2.SetActive(false);
                ot = true;
            }
            else if (target.tag == "Player2")
            {
                platformActivationP0.SetActive(false);
                platformActivationP2.SetActive(true);
                platformActivationP1.SetActive(false);
                ot = true;
            }
        }
    }

}
