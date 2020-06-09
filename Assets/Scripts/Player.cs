using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _cc;
    [SerializeField]
    private float _speed = 3.5f;
    private float _gravity = 9.81f;
    [SerializeField]
    private GameObject _muzzleFlash;
    [SerializeField]
    private GameObject _bulletHole;

    [SerializeField]
    private int _ammo;
    private int _startAmmo=50;

    private bool _isReloading;
    // Start is called before the first frame update
    void Start()
    {
        
        _cc = GetComponent<CharacterController>();
        _ammo=_startAmmo;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (_ammo>0)
        {
            if (Input.GetMouseButton(0))
            {
                Shoot();
            }
            
                _muzzleFlash.SetActive(false);
        
        }

        if (Input.GetKeyDown(KeyCode.R) && !_isReloading)
        {
            _isReloading = true;
            Reload();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

      
            MovementCalc();
       
    }

    private void Shoot()
    {
        _muzzleFlash.SetActive(true);
        Debug.Log("ey");
        _ammo--;

        //position ray casted from 
        Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            if(hitInfo.collider.tag == "Enemy")
            {

            }
            else { 
            GameObject hitMarker =Instantiate(_bulletHole, hitInfo.point, Quaternion.LookRotation(hitInfo.normal)) as GameObject;
            Destroy(hitMarker, 1f);
            }
        }
    }

    void MovementCalc()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(x , 0, z);
        Vector3 velocity = direction * _speed;
        velocity.y -= _gravity;

        velocity = transform.transform.TransformDirection(velocity);
        _cc.Move(velocity * Time.deltaTime);
    }


    private void Reload()
    {
        StartCoroutine(ShootingCoolDownRoutine());
    }

    IEnumerator ShootingCoolDownRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        _ammo = _startAmmo;
        _isReloading = false;
    }

    IEnumerator CoolDownRoutine()
    {
        yield return new WaitForSeconds(5.0f);
    }

    public void _addAmmo()
    {
        _ammo = _startAmmo;
    }
}
