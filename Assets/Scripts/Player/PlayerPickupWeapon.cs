using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class PlayerPickupWeapon : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private GameObject _collectableWeapon;

    public GameObject CollectableWeapon { set => _collectableWeapon = value; }

    private void Awake()
    {
        _inventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _collectableWeapon != null)
        {
            WeaponData collectableWeaponData = _collectableWeapon.GetComponent<WeaponDrop>().WeaponData;
            PickupWeapon(collectableWeaponData, _collectableWeapon);
        }
    }

    private void PickupWeapon(WeaponData collectableWeapon, GameObject gameObject)
    {
        _inventory.AddWeapon(collectableWeapon);
        Destroy(gameObject);
    }
}
