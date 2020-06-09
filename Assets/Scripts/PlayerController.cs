using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int life_score = 100;
    private Animator animator;

    private HealthBarPlayer healthBar;
    
    private bool isDie = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        healthBar = GetComponent<HealthBarPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDie)
            IsAttacking();
        StartCoroutine(IsWon());
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
        if(life_score <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private void Attack()
    {
        animator.SetBool("isAttack", true);
        animator.Play("attack");
    }

    IEnumerator Die()
    {
        Debug.Log("Player die");
        isDie = true;
        animator.SetBool("isAttack", false);
        animator.SetBool("isStanding", false);
        animator.SetBool("isWalking", false);
        animator.SetBool("isDie", true);
        animator.Play("die");
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        this.GetComponent<Mover>().enabled = false;
        GameObject.Find("Text").GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(5);
        QuitGame();
    }

    IEnumerator IsWon()
    {
        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            GameObject.Find("Text").GetComponent<Text>().text = "You Win!";
            GameObject.Find("Text").GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(5);
            QuitGame();
        }
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }
}
