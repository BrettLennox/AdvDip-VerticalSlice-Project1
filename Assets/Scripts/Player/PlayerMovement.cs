using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Vector2 _moveDir;

    PlayerGroundCheck _playerGroundCheck;

    private void Awake()
    {
        _playerGroundCheck = GetComponent<PlayerGroundCheck>();
    }

    private void Update()
    {
        _moveDir.x = CalculatedMovement();
        transform.Translate(_moveDir * _speed * Time.deltaTime);
    }

    private float CalculatedMovement()
    {
        return Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
    }
}
