using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{
    [SerializeField] private WeaponData _weaponData;

    public WeaponData WeaponData { get => _weaponData; }
}
