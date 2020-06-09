using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
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
        float _mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = transform.localEulerAngles;
        rotation.x -= _mouseY * _speedRotation;
        transform.localEulerAngles = rotation;
    }
}
