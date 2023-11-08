using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation1 : MonoBehaviour
{
    [SerializeField] private Animator animator1;
    [SerializeField] private Animator animator2;
    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        animator1.SetBool("ARun", false);
        animator2.SetBool("ARun", false);
    }
}
