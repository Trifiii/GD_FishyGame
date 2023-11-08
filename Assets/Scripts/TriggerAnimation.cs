using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator1;
    [SerializeField] private Animator animator2;

    void Start()
    {}

    void Update()
    {
        animator1.SetBool("ARun", true);
        animator2.SetBool("ARun", true);
    }
}
