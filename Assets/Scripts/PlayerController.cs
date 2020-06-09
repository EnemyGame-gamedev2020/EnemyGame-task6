using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int life_score = 100;
    private Animator animator;

    private HealthBarPlayer healthBar;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        healthBar = GetComponent<HealthBarPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        IsAttacking();
    }

    private void IsAttacking()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isAttack", false);
        }
    }

    public void Damage()
    {
        Debug.Log("Player damage");
        life_score -= 10;
        healthBar.TakeDamage(10);
    }

    private void Attack()
    {
        animator.SetBool("isAttack", true);
        animator.Play("attack");
    }
}
