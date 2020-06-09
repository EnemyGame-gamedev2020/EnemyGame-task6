using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GameObject.Find("boody").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" && animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            other.gameObject.GetComponent<Enemy>().Damage();
        }
    }
}
