using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Friend : MonoBehaviour
{
    NavMeshAgent _nMA;
    // Start is called before the first frame update
    void Start()
    {
        _nMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            Physics.Raycast(ray, out hitInfo);
            _nMA.SetDestination(hitInfo.point);
           
        }
    }
}
