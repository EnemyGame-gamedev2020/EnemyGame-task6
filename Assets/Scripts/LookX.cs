using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField]
    private float _speedRotation = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = transform.localEulerAngles;
        rotation.y += _mouseX * _speedRotation;
        transform.localEulerAngles = rotation;

    }
}
