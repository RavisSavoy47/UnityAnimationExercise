using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAnimationBehaviour : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementBehaviour _playermovement;
    [SerializeField]
    private Animator _animator;

    private void Awake()
    {
        WinBoxBehaviour.OnWin += () => _animator.SetTrigger("Win");
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", _playermovement.Velocity.magnitude);

        _animator.SetBool("IsGrounded", _playermovement.IsGrounded);
    }
}
