using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("How many seconds the object remains in walk mode")] [SerializeField] float duration = 1f;
    Animator animator;
    [SerializeField] float speed = 8f;
    [SerializeField] float rotationSpeed = 50f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            StartCoroutine(GoToWalkMode());
        }
        else
        {

        }
    }

    IEnumerator GoToWalkMode()
    {
        animator.Play("walk");
        yield return new WaitForSeconds(duration);
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            animator.Play("stand");
        }
    }
}
