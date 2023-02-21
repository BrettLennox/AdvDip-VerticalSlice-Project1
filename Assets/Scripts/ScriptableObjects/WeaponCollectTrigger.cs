using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollectTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        bool isPlayer = collision.CompareTag("Player");
        
        if (isPlayer)
        {
            collision.GetComponent<PlayerPickupWeapon>().CollectableWeapon = this.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bool isPlayer = collision.CompareTag("Player");

        if (isPlayer)
        {
            collision.GetComponent<PlayerPickupWeapon>().CollectableWeapon = null;
        }
    }
}
