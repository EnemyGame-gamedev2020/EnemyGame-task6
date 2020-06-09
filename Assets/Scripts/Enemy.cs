using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] int life_score = 50;
    private Animator _animator;

    NavMeshAgent _navMeshAgent;
    private GameObject _target;
    [SerializeField] GameObject _player;
    private float NextState;
    [SerializeField] float lookRadius = 10f;
    [SerializeField] float attackRadius = 2f;
    private Vector3 _ppos;

    [SerializeField] Target escap_target;

    private HealthBarPlayer healthBar;
    private bool isEscapeMode = false;
    private bool isDie = false;

    private void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.LogError("Navmash null" + gameObject.name);
        }
        _animator = GetComponent<Animator>();
        _target = _player;
        _animator.SetBool("isStanding", false);
        _animator.SetBool("isWalking", true);
        _animator.Play("walk");
        _navMeshAgent.SetDestination(_target.transform.position);
        healthBar = GetComponent<HealthBarPlayer>();
    }

    private void Update()
    {
        if (!isDie)
        {
            _ppos = _player.transform.position;
            if (!_navMeshAgent.hasPath)
            {
                NextState -= Time.deltaTime;
                if (NextState <= 0 && !isEscapeMode)
                {
                    Walk();
                    _navMeshAgent.SetDestination(_target.transform.position);
                    NextState = Random.Range(3f, 7f);
                }
            }


            float distance = Vector3.Distance(_ppos, transform.position);
            if (distance <= lookRadius)
            {
                FacePlayer();
            }
            if (distance <= attackRadius && !_animator.GetCurrentAnimatorStateInfo(0).IsName("zombie attack"))
            {
                StartCoroutine(Attack());
                Stand();
            }
        }
    }

    private void Stand()
    {
        _animator.SetBool("isWalking", false);
        _animator.SetBool("isZombieAttack", false);
        _animator.SetBool("isStanding", true);
        _animator.Play("stand");
    }

    private void Walk()
    {
        _animator.SetBool("isStanding", false);
        _animator.SetBool("isZombieAttack", false);
        _animator.SetBool("isWalking", true);
        _animator.Play("walk");
    }

    IEnumerator Attack()
    {

        _animator.SetBool("isStanding", false);
        _animator.SetBool("isWalking", false);
        _animator.SetBool("isZombieAttack", true);
        _animator.Play("zombie attack");
        yield return new WaitForSeconds(5f);
        _animator.SetBool("isZombieAttack", false);
        _animator.SetBool("isStanding", true);
    }

    public void Damage()
    {
        Debug.Log("Enemy damage");
        life_score -= 30;
        healthBar.TakeDamage(30);
        if(life_score <= 0)
        {
            StartCoroutine(Die());
        }
        if(life_score < 40)
        {
            isEscapeMode = true;
            Walk();
            _navMeshAgent.SetDestination(escap_target.transform.position);
        }
    }

    IEnumerator Die()
    {
        Debug.Log(this.name + " die");
        isDie = true;
        _animator.SetBool("isZombieAttack", false);
        _animator.SetBool("isStanding", false);
        _animator.SetBool("isWalking", false);
        _animator.SetBool("isDie", true);
        _animator.Play("die");
        yield return new WaitForSeconds(_animator.GetCurrentAnimatorStateInfo(0).length + 3);
        Destroy(this.gameObject);
    }

    private void FacePlayer()
    {
        Vector3 direction = (_ppos - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0 , direction.z));
        // transform.rotation = lookRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    private void faceDirection()
    {
        Vector3 direction = (_navMeshAgent.destination - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        // transform.rotation = lookRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }
   

    //private Vector3 GetRandomDir()
    //{
    //    float x = UnityEngine.Random.Range(-1f, 1f);
    //    float z = UnityEngine.Random.Range(-1f, 1f);
    //    Vector3 dir=new Vector3(x,0,z).normalized;

    //    return startinPosition + dir * Random.Range(10f, 70f);
    //}
}
