using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<WeaponData> _collectedWeapons;

    public void AddWeapon(WeaponData weapon)
    {
        _collectedWeapons.Add(weapon);
    }
}
