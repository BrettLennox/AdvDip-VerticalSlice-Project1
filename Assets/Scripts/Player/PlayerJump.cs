using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerGroundCheck))]
public class PlayerJump : MonoBehaviour
{
    #region Variables
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] [Range(1,10)] private float _jumpMultiplier;
    private float _hiddenJumpMultiplier;
    private PlayerGroundCheck _playerGroundCheck;
    #endregion
    #region Properties

    #endregion

    private void Awake()
    {
        _playerGroundCheck = GetComponent<PlayerGroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        _hiddenJumpMultiplier = _jumpMultiplier * 100;

        if (Input.GetKeyDown(KeyCode.Space) && _playerGroundCheck.IsGrounded)
        {
            _rb.AddForce(Vector2.up * _hiddenJumpMultiplier, ForceMode2D.Force);
        }
    }
}
