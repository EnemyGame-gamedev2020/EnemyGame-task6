using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClaws : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && animator.GetCurrentAnimatorStateInfo(0).IsName("zombie attack"))
        {
            other.gameObject.GetComponent<PlayerController>().Damage();
        }
    }
}
