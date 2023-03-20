using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private ClickerHandler _clickerHandler;

    private Warrior _player;
    private const string DieAnim = "Die";
    private const string AttackAnim = "Attack";

    private void OnEnable()
    {
        _player = GetComponent<Warrior>();

        _player.Died += OnDied;
        _clickerHandler.Cliked += OnAttack;
    }

    private void OnDisable()
    {
        _clickerHandler.Cliked -= OnAttack;
    }

    private void OnAttack()
    {
        _animator.SetTrigger(AttackAnim);
    }


    private void OnDied()
    {
        _animator.SetTrigger(DieAnim);
    }
}
