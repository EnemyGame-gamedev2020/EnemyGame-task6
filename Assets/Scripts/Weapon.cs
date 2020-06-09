using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    AudioSource _audioS;
    // Start is called before the first frame update
    void Start()
    {
        _audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _audioS.Play();
            
        }
    }

}
