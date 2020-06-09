using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponProp : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if(player!=null)
                {
                    player._addAmmo();
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
